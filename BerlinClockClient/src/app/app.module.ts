import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BerlinClockComponent } from './clock/berlin-clock.component';
import { LampRowComponent } from './clock/lamp-row.component';

@NgModule({
  declarations: [
    AppComponent,
    BerlinClockComponent,
    LampRowComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
