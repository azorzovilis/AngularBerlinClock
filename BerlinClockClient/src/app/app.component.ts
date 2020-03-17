import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <!--The content below is only a placeholder and can be replaced.-->
    <div style="text-align:center" class="content">
      <h1>
        Welcome to {{title}}!
      </h1>
      <span style="display: block">{{ title }} app is running!</span>
    </div>

    <div class="outer-container">

      <div class="outer circle">
        <div class="inner circle yellow">&nbsp;</div>
      </div>

      <div class="container">
        <div class="box box-first red"></div>
        <div class="box red"></div>
        <div class="box switched-off-red"></div>
        <div class="box-last switched-off-red"></div>
      </div>

      <div class="container">
        <div class="box box-first red"></div>
        <div class="box red"></div>
        <div class="box switched-off-red"></div>
        <div class="box-last switched-off-red"></div>
      </div>
  
      <div class="container">
        <div class="box box-first yellow"></div>
        <div class="box yellow"></div>
        <div class="box red"></div>
        <div class="box yellow"></div>
        <div class="box yellow"></div>
        <div class="box red"></div>
        <div class="box switched-off-yellow"></div>
        <div class="box switched-off-yellow"></div>
        <div class="box switched-off-red"></div>
        <div class="box switched-off-yellow"></div>
        <div class="box-last switched-off-yellow"></div>
      </div>

      <div class="container">
        <div class="box box-first yellow"></div>
        <div class="box switched-off-yellow"></div>
        <div class="box switched-off-yellow"></div>
        <div class="box-last switched-off-yellow"></div>
      </div>
    </div>
    
  `,
  styles: [`
    .outer-container {
      width: 623px;
      margin: 0 auto;
    }

    .container {
      width:431px;
      height:68px; 
      background-color: #edf1f1; 
      padding: 10px 11px 7px;
      border-radius: 23px;
      margin: 0 auto;
      display: flex;
      margin-bottom: 4px;
    }

    .circle { border-radius: 50%; }

    .outer {
      background-color:#edf1f1;
      width:150px;
      height:150px;
      position:relative;
      margin: 0 auto;
      margin-bottom: 4px;
    }

    .inner {
      top: 7%; left:8%;
      width:85%;
      height:85%;
      position: relative;
    }

    .container div{
      width: 23%;
      height:65px;
    }

    .box{
      margin-right:13px;
    }

    .box-first{
      border-top-left-radius: 26px 20px;
      border-bottom-left-radius: 26px 20px;
    }

    .box-last{
      border-top-right-radius: 26px 20px;
      border-bottom-right-radius: 26px 20px;
    }

    .red { background-color: #f56475; }
    .switched-off-red { background-color: #97616f; }
    .yellow { background-color: #fef900; }
    .switched-off-yellow { background-color: #d4a259; }
  `]
})

export class AppComponent {
  title = 'BerlinClockClient';
}