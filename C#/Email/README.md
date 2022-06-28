# Email

This is a SMTP application that sends an attachment out using
[MailKit](https://github.com/jstedfast/MailKit) and
[MineKit](https://github.com/jstedfast/MimeKit).
This is a standalone application to send out emails if your printer application
does not send a email out.

## Dependencies

- [MailKit](https://github.com/jstedfast/MailKit)
- [MineKit](https://github.com/jstedfast/MimeKit)

## Building

Use Visual Studio 2019 to build the project in Windows. Use `dotnet build` to
build in Linux. You need Dotnet 5 SDK to build.

## Usage

```bash
Email.exe File_Path_Here
```

Use an editor to view the code. Use Visual Studio Code for a better experience.
Open this folder for a better folder structure in your preferred editor. Make sure you edit the info inside the Project.cs file so the contacts are correct.

## Contributing

Read the Contributing section in README.md at the root of the repository.

## License

See [LICENSE](../../LICENSE) at the root of the repository. Additional licenses
is in the project [LICENSE](./LICENSE).
The first part of the project license is here if applicable.

```markdown
MailKit and MimeKit
MIT License

Copyright (C) 2013-2020 .NET Foundation and Contributors

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```
