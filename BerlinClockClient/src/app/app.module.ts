import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { BerlinClockComponent } from './clock/berlin-clock.component';

@NgModule({
  declarations: [
    AppComponent,
    BerlinClockComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
