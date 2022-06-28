# Tetris

A simple Tetris game from [FamTrinli](https://www.youtube.com/channel/UCC7qpnId5RIQruKDJOt2exw)
using SFML.

## Building

Use make/gcc to build the project. You need to install or SFML to get the
dlls, and libs depending on your distro. **NOTE**: You may need to edit
the make file to point to the install of SFML. The current config is
/usr/include, change the directory accordingly.

```bash
make
```

## Usage

You need to put the SFML dlls in the application's directory. Then open the
application.

## Contributing

Read the Contributing section in [README.md](../../README.md) at the root of the
repository.

## License

See [LICENSE](../../../LICENSE) at the root of the repository. Additional
licenses is in the project [LICENSE](./LICENSE).
The first part of the project license is here if applicable.

```markdown
SFML (Simple and Fast Multimedia Library) - Copyright (c) Laurent Gomila

This software is provided 'as-is', without any express or implied warranty.
In no event will the authors be held liable for any damages arising from
the use of this software.

Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:

1. The origin of this software must not be misrepresented; you must not claim
   that you wrote the original software. If you use this software in a product,
   an acknowledgment in the product documentation would be appreciated but is
   not required.

2. Altered source versions must be plainly marked as such, and must not be
   misrepresented as being the original software.

3. This notice may not be removed or altered from any source distribution.
```
