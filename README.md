# What is this

Boilterplate for making a game using [LittleJS](https://github.com/KilledByAPixel/LittleJS) and [Fable](https://github.com/fable-compiler/Fable)

# How To Use

1. run `make init`
2. run `make watch`
3. open 'http://localhost:5173' in your web browser


# Note

`src/LittleJS.fs` was created using following command.

```
$ ts2fable node_modules/littlejsengine/build/littlejs.d.ts src/LitteJS.fs
```

some type such as `AudioBufferSourceNode` is not defined so added manually.

