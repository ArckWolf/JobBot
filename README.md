# JobBot
Scan for jobs and accept them if they are suitable.

<p align="left">
  <img src="http://ouroborosrg.16mb.com/RG_GIF.gif" width="auto"/>
</p>
## This program allows users to accept automatically suitable job offers from betgenius, a site that posts them online. Bot accepts only those jobs that fit to users chosen criteria’s. 

<dl>
  <dt>User can choose the time period when he or she is free to Accept jobs</dt>
  <dt>User can choose the type of job to accept </dt>
  <dd>•	Media</dd>
  <dd>•	InRunning</dd>
  <dd>•	Resource</dd>
  <dd>•	QC</dd>
  <dd>•	UATTesting</dd>
  <dd>•	Breadcasting</dd>
</dl>

## This program has two parts: MainProgram and Server
### Server: contains .php files that output xml to the program
<p>Server makes sure that only limited number of users can be online simultaneously. </p>
<dl>
  <dt>Also program gets its settings from server:</dt>
  <dd>•	Program version: what version of program is allowed to run</dd>
  <dd>•	Refresh rate: How often program can check for jobs</dd>
  <dd>•	Check-in: How often must program report in</dd>
  <dd>•	Online time: How long user can continuously run the bot</dd>
  <dd>•	Cleanup time: How long can program stand idle (not searching) </dd>
</dl>
<p>The user limit and refresh limit is necessary to protect the target site from overloading. These setting values have been selected with the knowledge that a lot of users use auto refresh sites and autoclickers that take any job that appear without taking account users wishes.</p>
### MainProgram: contains the main program in .vb
<p>Program has many views: LOGIN, CALENDAR, MAIN, WIDGET ….</p>
<p>User is allowed to login only if user limit is not exceeded and user has provided correct site authentication information. </p>
<p>After successful login users authentication details will be encrypted and saved to programs root directory.  Next time when user login their login information is decrypted and filled in.</p>
<p>After login user is prompted to choose their time period when they are free to accept jobs. They can add and remove if necessary. After finishing, the information is automatically saved for next login.</p>
<p>After calendar settings user can choose what type of tasks they would want to accept. </p>
<p>If all settings have been chosen the program can be started. </p>
<p>Program can also be minimized. This will make it into a widget and remove it from taskbar.</p>
<p>Program has also safety protocol for login cookie expiring. When it detects that login cookie is expired it will automatically re-login to the site and refresh the cookie.</p>
<p>When program has been running too long (Online time) or has been idle for too long (Cleanup time) the search will be ended and user will be logged out.</p>
