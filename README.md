# SignalR - updating the UI in Asp.Net Core Web Application
Sometimes we have to run time taking jobs in the application like
 <ul>
 <li>Backing up and restoring databases from application UI</li>
 <li>Process the data</li>
  <li>Some kind of Schedulers from the application UI etc</li>
  </ul>

We have to continusly send the updates to the UI without refreshing it.

Here we can use SignalR to send the updates to the UI from the controller.

Our requirement is to process some data and that takes following steps
 <ul>
  <li>Retrieve the data</li>
 <li>Process the data</li>
 <li>Update the data</li>
 <li>Write into logs</li>
  <li>Send emails</li>
  </ul>

And on completion/failure of each job, UI should be updated with respective status

<a href="https://youtu.be/UyF41638RN0">Watch this (SignalR updating the UI in Asp.Net Core Web Application) tutorial on Youtube</a></br>
<a href="https://www.youtube.com/watch?v=_RepoZyMtL4&list=PLo-ZNwEHZHqbKSHEbpZX8u3X2WR1wlAH2">Watch complete SignalR playlist on Youtube</a></br>

Follow us on <br/>
<a href="https://twitter.com/Skynetechs">twitter</a> <br/>
<a href="https://www.facebook.com/Skynetfor.net">facebook</a>

<br/>
<a href="https://github.com/Skynet-Demos">All Skynet-Demo Git Repos</a> <br/>
