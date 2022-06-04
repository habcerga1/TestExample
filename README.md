![Alt Text](https://media.giphy.com/media/TOWeGr70V2R1K/giphy.gif)

### 👨‍💻: Host settings:

Host runs on the port:
- :seedling: http://localhost:5000

- :seedling: https://localhost:7000

### 👨‍💻: Metrics:

- 🌈 [LOC](https://github.com/habcerga1/TestExample/blob/master/LOC.met)
- 🌈 [NOM](https://github.com/habcerga1/TestExample/blob/master/NOM.met)
- 🌈 https://localhost:7000/swagger/index.html

### 💻: How to use it:

- :zap: To test the handler for waiting for the file to be read, you can use get /api/catalog/test by passing to the request test.txt either test2.txt . 
The answer will be of the form  Request GUID, File GUID, Requested time, Response time. The request time is created when the file is read before 
await. If you immediately apply for different files, the request time will be ± the same. You can see it in 🛠 Debug console. The request blocking in this example was 4 seconds.

| Request Guid  | File Guid     | Requested time:| Response time     |
| ------------- | ------------- | ------------- | ------------- |
|Request: 46e0efdd-fc96-461b-9c57-077ff069768c | File Guid: 93c5dbb0-c46a-4794-a35b-67a7ef0cc5e1 | Requested time: 06/03/2022 20:46:44  | Response time: 06/03/2022 20:46:48|
|Request: e0880b75-31ae-4ba1-8c19-c6cb146b4e37 | File Guid: 93c5dbb0-c46a-4794-a35b-67a7ef0cc5e1 | Requested time: 06/03/2022 20:46:44  | Response time: 06/03/2022 20:46:48|
|Request: fd7984f0-9451-41a4-9ec4-353e1537d91f | File Guid: 93c5dbb0-c46a-4794-a35b-67a7ef0cc5e1 | Requested time: 06/03/2022 20:46:44  | Response time: 06/03/2022 20:46:48|
|Request: 74938028-73c3-43d3-8a24-496deb8a91f1 | File Guid: 93c5dbb0-c46a-4794-a35b-67a7ef0cc5e1 | Requested time: 06/03/2022 20:46:44  | Response time: 06/03/2022 20:46:48|
|Request: 377483b6-2a7e-4285-9c0f-20d432ab89f2 | File Guid: 3bd330aa-8b97-4122-beb1-a2d23ec337be | Requested time: 06/03/2022 20:46:45  | Response time: 06/03/2022 20:46:49|
|Request: c017e99d-b27d-4ec1-be7c-b6a445b2d655 | File Guid: 3bd330aa-8b97-4122-beb1-a2d23ec337be | Requested time: 06/03/2022 20:46:45  | Response time: 06/03/2022 20:46:49|
|Request: c1e8c9d7-7ee7-4c47-8d64-abc27d738cc2 | File Guid: 3bd330aa-8b97-4122-beb1-a2d23ec337be | Requested time: 06/03/2022 20:46:45  | Response time: 06/03/2022 20:46:49|
|Request: a34acc54-7972-42e1-b7ea-04e538c4e79f | File Guid: 3bd330aa-8b97-4122-beb1-a2d23ec337be | Requested time: 06/03/2022 20:46:45  | Response time: 06/03/2022 20:46:49|





### :hammer_and_wrench: Languages and Tools :
<div>
  <img src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-plain.svg" title="Java" alt="Java" width="40" height="40"/>&nbsp;
  <img src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg" title="Java" alt="Java" width="40" height="40"/>&nbsp;
  <img src="https://seeklogo.com/images/S/swagger-logo-A49F73BAF4-seeklogo.com.png" title="Java" alt="Java" width="40" height="40"/>&nbsp;
</div>

