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
        <div class="box1 red"></div>
        <div class="box2 red"></div>
        <div class="box3 switched-off-red"></div>
        <div class="box-last switched-off-red"></div>
      </div>

      <div class="container">
        <div class="box1 red"></div>
        <div class="box2 red"></div>
        <div class="box3 switched-off-red"></div>
        <div class="box-last switched-off-red"></div>
      </div>
  
      <div class="container">
        <div class="box1 yellow"></div>
        <div class="box2 yellow"></div>
        <div class="box3 red"></div>
        <div class="box4 yellow"></div>
        <div class="box5 yellow"></div>
        <div class="box6 red"></div>
        <div class="box7 switched-off-yellow"></div>
        <div class="box8 switched-off-yellow"></div>
        <div class="box9 switched-off-red"></div>
        <div class="box10 switched-off-yellow"></div>
        <div class="box-last switched-off-yellow"></div>
      </div>

      <div class="container">
        <div class="box1 yellow"></div>
        <div class="box2 switched-off-yellow"></div>
        <div class="box3 switched-off-yellow"></div>
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

    .box1{
      border-top-left-radius: 26px 20px;
      border-bottom-left-radius: 26px 20px;
    }

    .box1, .box2, .box3, .box4, .box5, .box6, .box7, .box8, .box9, .box10 {
      margin-right:13px;
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