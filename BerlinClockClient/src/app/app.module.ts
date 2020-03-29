import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { BerlinClockComponent } from './clock/berlin-clock.component';
import { LampCircleComponent } from './clock/lamp-circle.component';
import { LampRowComponent } from './clock/lamp-row.component';
import { BerlinClockService } from './services/berlin-clock.service';

@NgModule({
  declarations: [
    AppComponent,
    BerlinClockComponent,
    LampCircleComponent,
    LampRowComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [BerlinClockService],
  bootstrap: [AppComponent]
})
export class AppModule { }
