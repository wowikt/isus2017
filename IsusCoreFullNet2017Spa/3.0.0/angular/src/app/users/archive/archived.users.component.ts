import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { IsusUserServiceProxy, IsusUserDto, PagedResultDtoOfIsusUserDto } from '@shared/service-proxies/service-proxies';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { CreateUserComponent } from "app/users/create-user/create-user.component";
import { EditUserComponent } from "app/users/edit-user/edit-user.component";

@Component({
    templateUrl: './archived.users.component.html',
    animations: [appModuleAnimation()]
})
export class ArchivedUsersComponent extends PagedListingComponentBase<IsusUserDto> {

    active: boolean = false;
    isusUsers: IsusUserDto[] = [];

    constructor(
        injector: Injector,
        private _isusUserService: IsusUserServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this._isusUserService.getAll(request.skipCount, request.maxResultCount, undefined)
            .finally(() => {
                finishedCallback();
            })
            .subscribe((result: PagedResultDtoOfIsusUserDto) => {
                this.isusUsers = result.items;
                this.showPaging(result, pageNumber);
            });
    }

    protected delete(entity: any): void {
        throw new Error("Method not implemented.");
    }

    protected moveUserToMainList(user: IsusUserDto): void {
        this.isTableLoading = true;
        this._isusUserService.moveToMainUserTable(user.id)
            .finally(() => {
                this.isTableLoading = false;
            })
            .subscribe((result: boolean) => {
                this.getDataPage(this.pageNumber);
            });
    }
}
