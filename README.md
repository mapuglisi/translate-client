# Translation Client

**Simple Translation** is a machine translation tool that can translate sentences between 3 popular languages (English, German and French).

The client is a simple, one page,  Blazor WASM, with a straightforward layout using [blazor bootstrap](https://blazorstrap.io/)  and C#, consuming the **Translation Server** API.



## Installation

Download the code from [repository](https://github.com/mapuglisi/translate-client.git)

You can run this project by using the command `dotnet run` while in the code folder.



## Docker

Build the blazor image by using the following command:

```bash
docker build -t translation-client:v1 .
```

Then run the image in a container:

```bash
docker run -it --rm -p 8080:80 translation-client:v1
```



## Usage

Go to [localhost:8080](http://localhost:8080/), select the source language of the original text and the target language you want the text translated to then press the translate button

## ![Client](https://raw.githubusercontent.com/mapuglisi/translate-client/main/Client.png)



## License

[MIT](https://choosealicense.com/licenses/mit/)

