import { Component, Injector, ElementRef, AfterViewInit, Output, EventEmitter, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ModalDirective } from 'ngx-bootstrap';
import { IsusUserServiceProxy } from '@shared/service-proxies/service-proxies'
import { AppComponentBase } from '@shared/app-component-base';
import { accountModuleAnimation } from '@shared/animations/routerTransition';

import * as _ from "lodash";

@Component({
    selector: 'move-user-to-main-list-modal',
    templateUrl: './move-user-to-main-list.component.html'
})
export class MoveUserToMainListComponent extends AppComponentBase implements AfterViewInit {

    @ViewChild('moveUserToMainListModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;

    userName: string;
    password: string;
    confirmPassword: string;
    userId: number;

    constructor(
        injector: Injector,
        private _isusUserService: IsusUserServiceProxy
    ) {
        super(injector);
    }

    ngAfterViewInit(): void {
        $(this.modalContent.nativeElement).find('input:first').focus();
    }

    save(): void {
        this.saving = true;
        this._isusUserService.moveToMainUserTable(this.userId, this.userName, this.password)
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

    show(userId: number): void {
        this.active = true;
        this.modal.show();
        this.userId = userId;
        this.userName = '';
        this.password = '';
        this.confirmPassword = '';
    }
}
