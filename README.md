# Mass Transit w/RabbitMQ Sample

First, run the command below to spin up an instance of MassTransit configured RabbitMQ instance.

```sh
docker run -p 15672:15672 -p 5672:5672 masstransit/rabbitmq
```

Then run the application, type away and see the Publisher and Consumer sending and receiving messages.

### Walkthrough

Please watch [Nick Chapsas](https://www.youtube.com/@nickchapsas)'s [Build Clean Messaging in .NET with MassTransit](https://www.youtube.com/watch?v=4FFYefcx4Bg) video for main walkthrough.

Then follow through the [quick start guide for RabbitMQ from MassTransit](https://masstransit.io/quick-starts/rabbitmq).
