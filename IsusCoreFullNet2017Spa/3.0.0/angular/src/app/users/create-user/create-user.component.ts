import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { UserServiceProxy, CreateUserDto, RoleDto, UserCardDto, UserCardBodyItemDto, UserCardHistoryItemDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

import * as _ from "lodash";

@Component({
  selector: 'create-user-modal',
  templateUrl: './create-user.component.html'
})
export class CreateUserComponent extends AppComponentBase implements OnInit {

    @ViewChild('createUserModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    user: CreateUserDto = null;
    roles: RoleDto[] = null;
    minBirthdate = new Date(1917, 1, 1);
    maxBirthdate = Date.now();

    constructor(
        injector: Injector,
        private _userService: UserServiceProxy
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this._userService.getRoles()
        .subscribe((result) => {
            this.roles = result.items;
        });
    }

    show(): void {
        this.active = true;
        this.modal.show();
        this.user = new CreateUserDto();
        this.user.isActive = true;
        this.user.userCard = new UserCardDto();
        this.user.userCard.body = [];
        this.user.userCard.body.push(new UserCardBodyItemDto());
        this.user.userCard.history = [];
        this.user.userCard.history.push(new UserCardHistoryItemDto());
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        //TODO: Refactor this, don't use jQuery style code
        var roles = [];
        $(this.modalContent.nativeElement).find("[name=role]").each((ind:number, elem:Element) => {
            if($(elem).is(":checked") == true){
                roles.push(elem.getAttribute("value").valueOf());
            }
        });

        this.user.roleNames = roles;
        this.user.name = this.user.userCard.body[0].firstName;
        this.user.surname = this.user.userCard.body[0].lastName;
        this.saving = true;
        this._userService.create(this.user)
            .finally(() => { this.saving = false; })
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
