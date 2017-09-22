import { Component, ViewContainerRef, Injector, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { AppConsts } from '@shared/AppConsts';
import { AppComponentBase } from '@shared/app-component-base';

import { SignalRHelper } from '@shared/helpers/SignalRHelper';
import { ChangePasswordComponent } from "app/users/change-password/change-password.component";

@Component({
  templateUrl: './app.component.html'
})
export class AppComponent extends AppComponentBase implements OnInit, AfterViewInit {
    @ViewChild('changePasswordModal') changePasswordModal: ChangePasswordComponent;

  private viewContainerRef: ViewContainerRef;

  constructor(
    injector: Injector
  ) {
    super(injector);
  }

  ngOnInit(): void {
    if (this.appSession.application.features['SignalR']) {
      SignalRHelper.initSignalR();
    }

    abp.event.on('abp.notifications.received', userNotification => {
      abp.notifications.showUiNotifyForUserNotification(userNotification);

      //Desktop notification
      Push.create("AbpZeroTemplate", {
        body: userNotification.notification.data.message,
        icon: abp.appPath + 'assets/app-logo-small.png',
        timeout: 6000,
        onClick: function () {
          window.focus();
          this.close();
        }
      });
    });
  }

  ngAfterViewInit(): void {
    ($ as any).AdminBSB.activateAll();
    ($ as any).AdminBSB.activateDemo();
  }

    changePassword(): void {
        this.changePasswordModal.show();
    }
}
