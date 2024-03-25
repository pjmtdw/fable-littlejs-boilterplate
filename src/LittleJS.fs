// ts2fable 0.7.1
// this code was created by ts2fable
// $ ts2fable node_modules/littlejsengine/build/littlejs.d.ts LitteJS.fs
// note that some types are not in https://github.com/fable-compiler/fable-browser
// so I temporary defined as `System.Object`

module rec littlejs
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Function = System.Action

let [<Import("*","littlejsengine")>] littlejs: Littlejs_esm.IExports = jsNative

module Littlejs_esm =

    type [<AllowNullLiteral>] IExports =
        /// Set position of camera in world space
        abstract setCameraPos: pos: Vector2 -> unit
        /// Set scale of camera in world space
        abstract setCameraScale: scale: float -> unit
        /// Set max size of the canvas
        abstract setCanvasMaxSize: size: Vector2 -> unit
        /// Set fixed size of the canvas
        abstract setCanvasFixedSize: size: Vector2 -> unit
        /// Disables anti aliasing for pixel art if true
        abstract setCanvasPixelated: pixelated: bool -> unit
        /// Set default font used for text rendering
        abstract setFontDefault: font: string -> unit
        /// Set if webgl rendering is enabled
        abstract setGlEnable: enable: bool -> unit
        /// Set to not composite the WebGL canvas
        abstract setGlOverlay: overlay: bool -> unit
        /// Set default size of tiles in pixels
        abstract setTileSizeDefault: size: Vector2 -> unit
        /// Set to prevent tile bleeding from neighbors in pixels
        abstract setTileFixBleedScale: scale: float -> unit
        /// Set if collisions between objects are enabled
        abstract setEnablePhysicsSolver: enable: bool -> unit
        /// Set default object mass for collison calcuations
        abstract setObjectDefaultMass: mass: float -> unit
        /// Set how much to slow velocity by each frame
        abstract setObjectDefaultDamping: damp: obj option -> unit
        /// Set how much to slow angular velocity each frame
        abstract setObjectDefaultAngleDamping: damp: obj option -> unit
        /// Set how much to bounce when a collision occur
        abstract setObjectDefaultElasticity: elasticity: float -> unit
        /// Set how much to slow when touching
        abstract setObjectDefaultFriction: friction: float -> unit
        /// Set max speed to avoid fast objects missing collisions
        abstract setObjectMaxSpeed: speed: float -> unit
        /// Set how much gravity to apply to objects along the Y axis
        abstract setGravity: g: obj option -> unit
        /// Set to scales emit rate of particles
        abstract setParticleEmitRateScale: scale: float -> unit
        /// Set if gamepads are enabled
        abstract setGamepadsEnable: enable: bool -> unit
        /// Set if the dpad input is also routed to the left analog stick
        abstract setGamepadDirectionEmulateStick: enable: bool -> unit
        /// Set if true the WASD keys are also routed to the direction keys
        abstract setInputWASDEmulateDirection: enable: bool -> unit
        /// Set if touch gamepad should appear on mobile devices
        abstract setTouchGamepadEnable: enable: bool -> unit
        /// Set if touch gamepad should be analog stick or 8 way dpad
        abstract setTouchGamepadAnalog: analog: bool -> unit
        /// Set size of virutal gamepad for touch devices in pixels
        abstract setTouchGamepadSize: size: float -> unit
        /// Set transparency of touch gamepad overlay
        abstract setTouchGamepadAlpha: alpha: float -> unit
        /// Set to allow vibration hardware if it exists
        abstract setVibrateEnable: enable: bool -> unit
        /// Set to disable all audio code
        abstract setSoundEnable: enable: bool -> unit
        /// Set volume scale to apply to all sound, music and speech
        abstract setSoundVolume: volume: float -> unit
        /// Set default range where sound no longer plays
        abstract setSoundDefaultRange: range: float -> unit
        /// Set default range percent to start tapering off sound
        abstract setSoundDefaultTaper: taper: float -> unit
        /// Set how long to show medals for in seconds
        abstract setMedalDisplayTime: time: float -> unit
        /// Set how quickly to slide on/off medals in seconds
        abstract setMedalDisplaySlideTime: time: float -> unit
        /// Set size of medal display
        abstract setMedalDisplaySize: size: Vector2 -> unit
        /// Set size of icon in medal display
        abstract setMedalDisplayIconSize: size: float -> unit
        /// Set to stop medals from being unlockable
        abstract setMedalsPreventUnlock: preventUnlock: bool -> unit
        /// Set if watermark with FPS should be shown
        abstract setShowWatermark: show: bool -> unit
        /// Set key code used to toggle debug mode, Esc by default
        abstract setDebugKey: key: float -> unit
        abstract canvasMaxSize: Vector2
        abstract canvasFixedSize: Vector2
        abstract canvasPixelated: bool
        abstract fontDefault: string
        abstract tileSizeDefault: Vector2
        abstract tileFixBleedScale: float
        abstract enablePhysicsSolver: bool
        abstract objectDefaultMass: float
        abstract objectDefaultDamping: float
        abstract objectDefaultAngleDamping: float
        abstract objectDefaultElasticity: float
        abstract objectDefaultFriction: float
        abstract objectMaxSpeed: float
        abstract gravity: float
        abstract particleEmitRateScale: float
        abstract cameraPos: Vector2
        abstract cameraScale: float
        abstract glEnable: bool
        abstract glOverlay: bool
        abstract gamepadsEnable: bool
        abstract gamepadDirectionEmulateStick: bool
        abstract inputWASDEmulateDirection: bool
        abstract touchGamepadEnable: bool
        abstract touchGamepadAnalog: bool
        abstract touchGamepadSize: float
        abstract touchGamepadAlpha: float
        abstract vibrateEnable: bool
        abstract soundEnable: bool
        abstract soundVolume: float
        abstract soundDefaultRange: float
        abstract soundDefaultTaper: float
        abstract medalDisplayTime: float
        abstract medalDisplaySlideTime: float
        abstract medalDisplaySize: Vector2
        abstract medalDisplayIconSize: float
        abstract debug: bool
        abstract showWatermark: bool
        /// Asserts if the experssion is false, does not do anything in release builds
        abstract ASSERT: [<ParamArray>] ``assert``: ResizeArray<obj option> -> unit
        /// Draw a debug rectangle in world space
        abstract debugRect: pos: Vector2 * ?size: Vector2 * ?color: string * ?time: float * ?angle: float * ?fill: bool -> unit
        /// Draw a debug circle in world space
        abstract debugCircle: pos: Vector2 * ?radius: float * ?color: string * ?time: float * ?fill: bool -> unit
        /// Draw a debug point in world space
        abstract debugPoint: pos: Vector2 * ?color: string * ?time: float * ?angle: float -> unit
        /// Draw a debug line in world space
        abstract debugLine: posA: Vector2 * posB: Vector2 * ?color: string * ?thickness: float * ?time: float -> unit
        /// Draw a debug axis aligned bounding box in world space
        abstract debugAABB: pA: obj option * sA: obj option * pB: obj option * sB: obj option * ?color: string -> unit
        /// Draw a debug axis aligned bounding box in world space
        abstract debugText: text: string * pos: Vector2 * ?size: float * ?color: string * ?time: float * ?angle: float * ?font: string -> unit
        /// Clear all debug primitives in the list
        abstract debugClear: unit -> unit
        /// Save a canvas to disk
        abstract debugSaveCanvas: canvas: HTMLCanvasElement * ?filename: string * ?``type``: string -> unit
        abstract PI: float
        /// Returns absoulte value of value passed in
        abstract abs: value: float -> float
        /// Returns lowest of two values passed in
        abstract min: valueA: float * valueB: float -> float
        /// Returns highest of two values passed in
        abstract max: valueA: float * valueB: float -> float
        /// Returns the sign of value passed in (also returns 1 if 0)
        abstract sign: value: float -> float
        /// Returns first parm modulo the second param, but adjusted so negative numbers work as expected
        abstract ``mod``: dividend: float * ?divisor: float -> float
        /// Clamps the value beween max and min
        abstract clamp: value: float * ?min: float * ?max: float -> float
        /// Returns what percentage the value is between valueA and valueB
        abstract percent: value: float * valueA: float * valueB: float -> float
        /// Returns signed wrapped distance between the two values passed in
        abstract distanceWrap: valueA: float * valueB: float * ?wrapSize: float -> float
        /// Linearly interpolates between values passed in with wrappping
        abstract lerpWrap: percent: float * valueA: float * valueB: float * ?wrapSize: float -> float
        /// Returns signed wrapped distance between the two angles passed in
        abstract distanceAngle: angleA: float * angleB: float -> float
        /// Linearly interpolates between the angles passed in with wrappping
        abstract lerpAngle: percent: float * angleA: float * angleB: float -> float
        /// Linearly interpolates between values passed in using percent
        abstract lerp: percent: float * valueA: float * valueB: float -> float
        /// Applies smoothstep function to the percentage value
        abstract smoothStep: percent: float -> float
        /// Returns the nearest power of two not less then the value
        abstract nearestPowerOfTwo: value: float -> float
        /// <summary>Returns true if two axis aligned bounding boxes are overlapping</summary>
        /// <param name="pointA">- Center of box A</param>
        /// <param name="sizeA">- Size of box A</param>
        /// <param name="pointB">- Center of box B</param>
        /// <param name="sizeB">- Size of box B</param>
        abstract isOverlapping: pointA: Vector2 * sizeA: Vector2 * pointB: Vector2 * sizeB: Vector2 -> bool
        /// <summary>Returns an oscillating wave between 0 and amplitude with frequency of 1 Hz by default</summary>
        /// <param name="frequency">- Frequency of the wave in Hz</param>
        /// <param name="amplitude">- Amplitude (max height) of the wave</param>
        /// <param name="t">- Value to use for time of the wave</param>
        abstract wave: ?frequency: float * ?amplitude: float * ?t: float -> float
        /// <summary>Formats seconds to mm:ss style for display purposes</summary>
        /// <param name="t">- time in seconds</param>
        abstract formatTime: t: float -> string
        /// Returns a random value between the two values passed in
        abstract rand: ?valueA: float * ?valueB: float -> float
        /// Returns a floored random value the two values passed in
        abstract randInt: valueA: float * ?valueB: float -> float
        /// Randomly returns either -1 or 1
        abstract randSign: unit -> float
        /// Returns a random Vector2 within a circular shape
        abstract randInCircle: ?radius: float * ?minRadius: float -> Vector2
        /// Returns a random Vector2 with the passed in length
        abstract randVector: ?length: float -> Vector2
        /// Returns a random color between the two passed in colors, combine components if linear
        abstract randColor: ?colorA: Color * ?colorB: Color * ?linear: bool -> Color
        abstract RandomGenerator: RandomGeneratorStatic
        abstract Vector2: Vector2Static
        abstract Color: ColorStatic
        abstract Timer: TimerStatic
        /// Create a 2d vector, can take another Vector2 to copy, 2 scalars, or 1 scalar
        abstract vec2: ?x: float * ?y: float -> Vector2
        /// <summary>Create a color object with RGBA values</summary>
        /// <param name="r">- red</param>
        /// <param name="g">- green</param>
        /// <param name="b">- blue</param>
        /// <param name="a">- alpha</param>
        abstract rgb: ?r: float * ?g: float * ?b: float * ?a: float -> Color
        /// <summary>Create a color object with HSLA values</summary>
        /// <param name="h">- hue</param>
        /// <param name="s">- saturation</param>
        /// <param name="l">- lightness</param>
        /// <param name="a">- alpha</param>
        abstract hsl: ?h: float * ?s: float * ?l: float * ?a: float -> Color
        abstract EngineObject: EngineObjectStatic
        abstract tileImage: CanvasImageSource
        abstract mainCanvas: HTMLCanvasElement
        abstract mainContext: CanvasRenderingContext2D
        abstract overlayCanvas: HTMLCanvasElement
        abstract overlayContext: CanvasRenderingContext2D
        abstract mainCanvasSize: Vector2
        /// Convert from screen to world space coordinates
        abstract screenToWorld: screenPos: Vector2 -> Vector2
        /// Convert from world to screen space coordinates
        abstract worldToScreen: worldPos: Vector2 -> Vector2
        /// <summary>Draw textured tile centered in world space, with color applied if using WebGL</summary>
        /// <param name="pos">- Center of the tile in world space</param>
        /// <param name="size">- Size of the tile in world space</param>
        /// <param name="tileIndex">- Tile index to use, negative is untextured</param>
        /// <param name="tileSize">- Tile size in source pixels</param>
        /// <param name="color">- Color to modulate with</param>
        /// <param name="angle">- Angle to rotate by</param>
        /// <param name="mirror">- If true image is flipped along the Y axis</param>
        /// <param name="additiveColor">- Additive color to be applied</param>
        /// <param name="useWebGL">- Use accelerated WebGL rendering</param>
        /// <param name="screenSpace">- If true the pos and size are in screen space</param>
        abstract drawTile: pos: Vector2 * ?size: Vector2 * ?tileIndex: float * ?tileSize: Vector2 * ?color: Color * ?angle: float * ?mirror: bool * ?additiveColor: Color * ?useWebGL: bool * ?screenSpace: bool -> unit
        /// Draw colored rect centered on pos
        abstract drawRect: pos: Vector2 * ?size: Vector2 * ?color: Color * ?angle: float * ?useWebGL: bool * ?screenSpace: bool -> unit
        /// Draw colored line between two points
        abstract drawLine: posA: Vector2 * posB: Vector2 * ?thickness: float * ?color: Color * ?useWebGL: bool * ?screenSpace: bool -> unit
        /// Draw directly to a 2d canvas context in world space
        abstract drawCanvas2D: pos: Vector2 * size: Vector2 * angle: float * mirror: bool * drawFunction: Function * ?context: CanvasRenderingContext2D * ?screenSpace: bool -> unit
        /// Enable normal or additive blend mode
        abstract setBlendMode: ?additive: bool * ?useWebGL: bool -> unit
        /// Draw text on overlay canvas in screen space
        /// Automatically splits new lines into rows
        abstract drawTextScreen: text: string * pos: Vector2 * ?size: float * ?color: Color * ?lineWidth: float * ?lineColor: Color * ?textAlign: string * ?font: string * ?context: CanvasRenderingContext2D -> unit
        /// Draw text on overlay canvas in world space
        /// Automatically splits new lines into rows
        abstract drawText: text: string * pos: Vector2 * ?size: float * ?color: Color * ?lineWidth: float * ?lineColor: Color * ?textAlign: string * ?font: string * ?context: CanvasRenderingContext2D -> unit
        abstract engineFontImage: obj option
        abstract FontImage: FontImageStatic
        /// Returns true if fullscreen mode is active
        abstract isFullscreen: unit -> bool
        /// Toggle fullsceen mode
        abstract toggleFullscreen: unit -> unit
        /// Returns true if device key is down
        abstract keyIsDown: key: float * ?device: float -> bool
        /// Returns true if device key was pressed this frame
        abstract keyWasPressed: key: float * ?device: float -> bool
        /// Returns true if device key was released this frame
        abstract keyWasReleased: key: float * ?device: float -> bool
        /// Clears all input
        abstract clearInput: unit -> unit
        /// Returns true if device key is down
        abstract mouseIsDown: key: float * ?device: float -> bool
        /// Returns true if device key was pressed this frame
        abstract mouseWasPressed: key: float * ?device: float -> bool
        /// Returns true if device key was released this frame
        abstract mouseWasReleased: key: float * ?device: float -> bool
        abstract mousePos: Vector2
        abstract mousePosScreen: Vector2
        abstract mouseWheel: float
        abstract isUsingGamepad: bool
        abstract preventDefaultInput: bool
        /// Returns true if gamepad button is down
        abstract gamepadIsDown: button: float * ?gamepad: float -> bool
        /// Returns true if gamepad button was pressed
        abstract gamepadWasPressed: button: float * ?gamepad: float -> bool
        /// Returns true if gamepad button was released
        abstract gamepadWasReleased: button: float * ?gamepad: float -> bool
        /// Returns gamepad stick value
        abstract gamepadStick: stick: float * ?gamepad: float -> Vector2
        abstract mouseToScreen: mousePos: obj option -> Vector2
        abstract gamepadsUpdate: unit -> unit
        /// <summary>Pulse the vibration hardware if it exists</summary>
        /// <param name="pattern">- a single value in miliseconds or vibration interval array</param>
        abstract vibrate: ?pattern: float -> unit
        /// Cancel any ongoing vibration
        abstract vibrateStop: unit -> unit
        abstract isTouchDevice: bool
        abstract Sound: SoundStatic
        abstract Music: MusicStatic
        /// <summary>Play an mp3, ogg, or wav audio from a local file or url</summary>
        /// <param name="url">- Location of sound file to play</param>
        /// <param name="volume">- How much to scale volume by</param>
        /// <param name="loop">- True if the music should loop</param>
        abstract playAudioFile: url: string * ?volume: float * ?loop: bool -> HTMLAudioElement
        /// <summary>Speak text with passed in settings</summary>
        /// <param name="text">- The text to speak</param>
        /// <param name="language">- The language/accent to use (examples: en, it, ru, ja, zh)</param>
        /// <param name="volume">- How much to scale volume by</param>
        /// <param name="rate">- How quickly to speak</param>
        /// <param name="pitch">- How much to change the pitch by</param>
        abstract speak: text: string * ?language: string * ?volume: float * ?rate: float * ?pitch: float -> SpeechSynthesisUtterance
        /// Stop all queued speech
        abstract speakStop: unit -> unit
        /// <summary>Get frequency of a note on a musical scale</summary>
        /// <param name="semitoneOffset">- How many semitones away from the root note</param>
        abstract getNoteFrequency: semitoneOffset: float * ?rootFrequency: float -> float
        abstract audioContext: obj option
        /// <summary>Play cached audio samples with given settings</summary>
        /// <param name="sampleChannels">- Array of arrays of samples to play (for stereo playback)</param>
        /// <param name="volume">- How much to scale volume by</param>
        /// <param name="rate">- The playback rate to use</param>
        /// <param name="pan">- How much to apply stereo panning</param>
        /// <param name="loop">- True if the sound should loop when it reaches the end</param>
        /// <param name="sampleRate">- Sample rate for the sound</param>
        abstract playSamples: sampleChannels: ResizeArray<obj option> * ?volume: float * ?rate: float * ?pan: float * ?loop: bool * ?sampleRate: float -> AudioBufferSourceNode
        /// <summary>Generate and play a ZzFX sound
        /// 
        /// <a href=https://killedbyapixel.github.io/ZzFX/>Create sounds using the ZzFX Sound Designer.</a></summary>
        /// <param name="zzfxSound">- Array of ZzFX parameters, ex. [.5,.5]</param>
        abstract zzfx: [<ParamArray>] zzfxSound: ResizeArray<obj option> -> AudioBufferSourceNode
        abstract tileCollision: ResizeArray<obj option>
        abstract tileCollisionSize: Vector2
        /// Clear and initialize tile collision
        abstract initTileCollision: size: Vector2 -> unit
        /// Set tile collision data
        abstract setTileCollisionData: pos: Vector2 * ?data: float -> unit
        /// Get tile collision data
        abstract getTileCollisionData: pos: Vector2 -> float
        /// Check if collision with another object should occur
        abstract tileCollisionTest: pos: Vector2 * ?size: Vector2 * ?``object``: EngineObject -> bool
        /// Return the center of tile if any that is hit (does not return the exact intersection)
        abstract tileCollisionRaycast: posStart: Vector2 * posEnd: Vector2 * ?``object``: EngineObject -> Vector2
        abstract TileLayerData: TileLayerDataStatic
        abstract TileLayer: TileLayerStatic
        abstract ParticleEmitter: ParticleEmitterStatic
        abstract Particle: ParticleStatic
        abstract medals: ResizeArray<obj option>
        abstract medalsPreventUnlock: bool
        /// Initialize medals with a save name used for storage
        /// - Call this after creating all medals
        /// - Checks if medals are unlocked
        abstract medalsInit: saveName: string -> unit
        /// <summary>This can used to enable Newgrounds functionality</summary>
        /// <param name="app_id">- The newgrounds App ID</param>
        /// <param name="cipher">- The encryption Key (AES-128/Base64)</param>
        abstract newgroundsInit: app_id: float * ?cipher: string -> unit
        abstract Medal: MedalStatic
        abstract Newgrounds: NewgroundsStatic
        abstract glCanvas: HTMLCanvasElement
        abstract glContext: WebGLRenderingContext
        /// Set the WebGl blend mode, normally you should call setBlendMode instead
        abstract glSetBlendMode: ?additive: bool -> unit
        /// Set the WebGl texture, not normally necessary unless multiple tile sheets are used
        /// - This may also flush the gl buffer resulting in more draw calls and worse performance
        abstract glSetTexture: ?texture: WebGLTexture -> unit
        /// Compile WebGL shader of the given type, will throw errors if in debug mode
        abstract glCompileShader: source: string * ``type``: obj option -> WebGLShader
        /// Create WebGL program with given shaders
        abstract glCreateProgram: vsSource: WebGLShader * fsSource: WebGLShader -> WebGLProgram
        /// Create WebGL texture from an image and set the texture settings
        abstract glCreateTexture: image: obj -> WebGLTexture
        /// Set up a post processing shader
        abstract glInitPostProcess: shaderCode: string * includeOverlay: bool -> unit
        abstract engineName: string
        abstract engineVersion: string
        abstract frameRate: float
        abstract timeDelta: float
        abstract engineObjects: ResizeArray<obj option>
        abstract frame: float
        abstract time: float
        abstract timeReal: float
        abstract paused: bool
        /// Set if game is paused
        abstract setPaused: _paused: obj option -> unit
        /// <summary>Start up LittleJS engine with your callback functions</summary>
        /// <param name="gameInit">- Called once after the engine starts up, setup the game</param>
        /// <param name="gameUpdate">- Called every frame at 60 frames per second, handle input and update the game state</param>
        /// <param name="gameUpdatePost">- Called after physics and objects are updated, setup camera and prepare for render</param>
        /// <param name="gameRender">- Called before objects are rendered, draw any background effects that appear behind objects</param>
        /// <param name="gameRenderPost">- Called after objects are rendered, draw effects or hud that appear above all objects</param>
        /// <param name="tileImageSource">- Tile image to use, everything starts when the image is finished loading</param>
        abstract engineInit: gameInit: Function * gameUpdate: Function * gameUpdatePost: Function * gameRender: Function * gameRenderPost: Function * ?tileImageSource: string -> unit
        /// Update each engine object, remove destroyed objects, and update time
        abstract engineObjectsUpdate: unit -> unit
        /// Destroy and remove all objects
        abstract engineObjectsDestroy: unit -> unit
        /// <summary>Triggers a callback for each object within a given area</summary>
        /// <param name="pos">- Center of test area</param>
        /// <param name="size">- Radius of circle if float, rectangle size if Vector2</param>
        /// <param name="callbackFunction">- Calls this function on every object that passes the test</param>
        /// <param name="objects">- List of objects to check</param>
        abstract engineObjectsCallback: ?pos: Vector2 * ?size: float * ?callbackFunction: Function * ?objects: ResizeArray<obj option> -> unit

    /// Seeded random number generator
    /// - Can be used to create a deterministic random number sequence
    type [<AllowNullLiteral>] RandomGenerator =
        abstract seed: float with get, set
        /// Returns a seeded random value between the two values passed in
        abstract float: ?valueA: float * ?valueB: float -> float
        /// Returns a floored seeded random value the two values passed in
        abstract int: valueA: float * ?valueB: float -> float
        /// Randomly returns either -1 or 1 deterministically
        abstract sign: unit -> float

    /// Seeded random number generator
    /// - Can be used to create a deterministic random number sequence
    type [<AllowNullLiteral>] RandomGeneratorStatic =
        /// <summary>Create a random number generator with the seed passed in</summary>
        /// <param name="seed">- Starting seed</param>
        [<Emit "new $0($1...)">] abstract Create: seed: float -> RandomGenerator

    /// 2D Vector object with vector math library
    /// - Functions do not change this so they can be chained together
    type [<AllowNullLiteral>] Vector2 =
        abstract x: float with get, set
        abstract y: float with get, set
        /// Returns a new vector that is a copy of this
        abstract copy: unit -> Vector2
        /// <summary>Returns a copy of this vector plus the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract add: v: Vector2 -> Vector2
        /// <summary>Returns a copy of this vector minus the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract subtract: v: Vector2 -> Vector2
        /// <summary>Returns a copy of this vector times the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract multiply: v: Vector2 -> Vector2
        /// <summary>Returns a copy of this vector divided by the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract divide: v: Vector2 -> Vector2
        /// <summary>Returns a copy of this vector scaled by the vector passed in</summary>
        /// <param name="s">- scale</param>
        abstract scale: s: float -> Vector2
        /// Returns the length of this vector
        abstract length: unit -> float
        /// Returns the length of this vector squared
        abstract lengthSquared: unit -> float
        /// <summary>Returns the distance from this vector to vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract distance: v: Vector2 -> float
        /// <summary>Returns the distance squared from this vector to vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract distanceSquared: v: Vector2 -> float
        /// Returns a new vector in same direction as this one with the length passed in
        abstract normalize: ?length: float -> Vector2
        /// Returns a new vector clamped to length passed in
        abstract clampLength: ?length: float -> Vector2
        /// <summary>Returns the dot product of this and the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract dot: v: Vector2 -> float
        /// <summary>Returns the cross product of this and the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract cross: v: Vector2 -> float
        /// Returns the angle of this vector, up is angle 0
        abstract angle: unit -> float
        /// Sets this vector with angle and length passed in
        abstract setAngle: ?angle: float * ?length: float -> Vector2
        /// Returns copy of this vector rotated by the angle passed in
        abstract rotate: angle: float -> Vector2
        /// Returns the integer direction of this vector, corrosponding to multiples of 90 degree rotation (0-3)
        abstract direction: unit -> float
        /// Returns a copy of this vector that has been inverted
        abstract invert: unit -> Vector2
        /// Returns a copy of this vector with each axis floored
        abstract floor: unit -> Vector2
        /// Returns the area this vector covers as a rectangle
        abstract area: unit -> float
        /// <summary>Returns a new vector that is p percent between this and the vector passed in</summary>
        /// <param name="v">- other vector</param>
        abstract lerp: v: Vector2 * percent: float -> Vector2
        /// Returns true if this vector is within the bounds of an array size passed in
        abstract arrayCheck: arraySize: Vector2 -> bool
        /// <summary>Returns this vector expressed as a string</summary>
        /// <param name="digits">- precision to display</param>
        abstract toString: ?digits: float -> string

    /// 2D Vector object with vector math library
    /// - Functions do not change this so they can be chained together
    type [<AllowNullLiteral>] Vector2Static =
        /// <summary>Create a 2D vector with the x and y passed in, can also be created with vec2()</summary>
        /// <param name="x">- X axis location</param>
        /// <param name="y">- Y axis location</param>
        [<Emit "new $0($1...)">] abstract Create: ?x: float * ?y: float -> Vector2

    /// Color object (red, green, blue, alpha) with some helpful functions
    type [<AllowNullLiteral>] Color =
        abstract r: float with get, set
        abstract g: float with get, set
        abstract b: float with get, set
        abstract a: float with get, set
        /// Returns a new color that is a copy of this
        abstract copy: unit -> Color
        /// <summary>Returns a copy of this color plus the color passed in</summary>
        /// <param name="c">- other color</param>
        abstract add: c: Color -> Color
        /// <summary>Returns a copy of this color minus the color passed in</summary>
        /// <param name="c">- other color</param>
        abstract subtract: c: Color -> Color
        /// <summary>Returns a copy of this color times the color passed in</summary>
        /// <param name="c">- other color</param>
        abstract multiply: c: Color -> Color
        /// <summary>Returns a copy of this color divided by the color passed in</summary>
        /// <param name="c">- other color</param>
        abstract divide: c: Color -> Color
        /// Returns a copy of this color scaled by the value passed in, alpha can be scaled separately
        abstract scale: scale: float * ?alphaScale: float -> Color
        /// Returns a copy of this color clamped to the valid range between 0 and 1
        abstract clamp: unit -> Color
        /// <summary>Returns a new color that is p percent between this and the color passed in</summary>
        /// <param name="c">- other color</param>
        abstract lerp: c: Color * percent: float -> Color
        /// <summary>Sets this color given a hue, saturation, lightness, and alpha</summary>
        /// <param name="h">- hue</param>
        /// <param name="s">- saturation</param>
        /// <param name="l">- lightness</param>
        /// <param name="a">- alpha</param>
        abstract setHSLA: ?h: float * ?s: float * ?l: float * ?a: float -> Color
        /// Returns this color expressed in hsla format
        abstract getHSLA: unit -> ResizeArray<obj option>
        /// Returns a new color that has each component randomly adjusted
        abstract mutate: ?amount: float * ?alphaAmount: float -> Color
        /// <summary>Returns this color expressed as a hex color code</summary>
        /// <param name="useAlpha">- if alpha should be included in result</param>
        abstract toString: ?useAlpha: bool -> string
        /// <summary>Set this color from a hex code</summary>
        /// <param name="hex">- html hex code</param>
        abstract setHex: hex: string -> Color
        /// Returns this color expressed as 32 bit RGBA value
        abstract rgbaInt: unit -> float

    /// Color object (red, green, blue, alpha) with some helpful functions
    type [<AllowNullLiteral>] ColorStatic =
        /// <summary>Create a color with the rgba components passed in, white by default</summary>
        /// <param name="r">- red</param>
        /// <param name="g">- green</param>
        /// <param name="b">- blue</param>
        /// <param name="a">- alpha</param>
        [<Emit "new $0($1...)">] abstract Create: ?r: float * ?g: float * ?b: float * ?a: float -> Color

    /// Timer object tracks how long has passed since it was set
    type [<AllowNullLiteral>] Timer =
        abstract time: float with get, set
        abstract setTime: float with get, set
        /// <summary>Set the timer with seconds passed in</summary>
        /// <param name="timeLeft">- How much time left before the timer is elapsed in seconds</param>
        abstract set: ?timeLeft: float -> unit
        /// Unset the timer
        abstract unset: unit -> unit
        /// Returns true if set
        abstract isSet: unit -> bool
        /// Returns true if set and has not elapsed
        abstract active: unit -> bool
        /// Returns true if set and elapsed
        abstract elapsed: unit -> bool
        /// Get how long since elapsed, returns 0 if not set (returns negative if currently active)
        abstract get: unit -> float
        /// Get percentage elapsed based on time it was set to, returns 0 if not set
        abstract getPercent: unit -> float
        /// Returns this timer expressed as a string
        abstract toString: unit -> string
        /// Get how long since elapsed, returns 0 if not set (returns negative if currently active)
        abstract valueOf: unit -> float

    /// Timer object tracks how long has passed since it was set
    type [<AllowNullLiteral>] TimerStatic =
        /// <summary>Create a timer object set time passed in</summary>
        /// <param name="timeLeft">- How much time left before the timer elapses in seconds</param>
        [<Emit "new $0($1...)">] abstract Create: ?timeLeft: float -> Timer

    /// LittleJS Object Base Object Class
    /// - Top level object class used by the engine
    /// - Automatically adds self to object list
    /// - Will be updated and rendered each frame
    /// - Renders as a sprite from a tilesheet by default
    /// - Can have color and addtive color applied
    /// - 2D Physics and collision system
    /// - Sorted by renderOrder
    /// - Objects can have children attached
    /// - Parents are updated before children, and set child transform
    /// - Call destroy() to get rid of objects
    /// 
    /// The physics system used by objects is simple and fast with some caveats...
    /// - Collision uses the axis aligned size, the object's rotation angle is only for rendering
    /// - Objects are guaranteed to not intersect tile collision from physics
    /// - If an object starts or is moved inside tile collision, it will not collide with that tile
    /// - Collision for objects can be set to be solid to block other objects
    /// - Objects may get pushed into overlapping other solid objects, if so they will push away
    /// - Solid objects are more performance intensive and should be used sparingly
    type [<AllowNullLiteral>] EngineObject =
        abstract pos: Vector2 with get, set
        abstract size: Vector2 with get, set
        abstract tileIndex: float with get, set
        abstract tileSize: Vector2 with get, set
        abstract angle: float with get, set
        abstract color: Color with get, set
        abstract mass: float with get, set
        abstract damping: float with get, set
        abstract angleDamping: float with get, set
        abstract elasticity: float with get, set
        abstract friction: float with get, set
        abstract gravityScale: float with get, set
        abstract renderOrder: float with get, set
        abstract velocity: Vector2 with get, set
        abstract angleVelocity: float with get, set
        abstract spawnTime: float with get, set
        abstract children: ResizeArray<obj option> with get, set
        abstract collideTiles: float with get, set
        /// Update the object transform and physics, called automatically by engine once each frame
        abstract update: unit -> unit
        abstract groundObject: obj option with get, set
        /// Render the object, draws a tile by default, automatically called each frame, sorted by renderOrder
        abstract render: unit -> unit
        /// Destroy this object, destroy it's children, detach it's parent, and mark it for removal
        abstract destroy: unit -> unit
        abstract destroyed: float with get, set
        /// <summary>Called to check if a tile collision should be resolved</summary>
        /// <param name="tileData">- the value of the tile at the position</param>
        /// <param name="pos">- tile where the collision occured</param>
        abstract collideWithTile: tileData: float * pos: Vector2 -> bool
        /// <summary>Called to check if a tile raycast hit</summary>
        /// <param name="tileData">- the value of the tile at the position</param>
        /// <param name="pos">- tile where the raycast is</param>
        abstract collideWithTileRaycast: tileData: float * pos: Vector2 -> bool
        /// <summary>Called to check if a object collision should be resolved</summary>
        /// <param name="object">- the object to test against</param>
        abstract collideWithObject: ``object``: EngineObject -> bool
        /// How long since the object was created
        abstract getAliveTime: unit -> float
        /// Apply acceleration to this object (adjust velocity, not affected by mass)
        abstract applyAcceleration: acceleration: Vector2 -> unit
        /// Apply force to this object (adjust velocity, affected by mass)
        abstract applyForce: force: Vector2 -> unit
        /// Get the direction of the mirror
        abstract getMirrorSign: unit -> float
        /// Attaches a child to this with a given local transform
        abstract addChild: child: EngineObject * ?localPos: Vector2 * ?localAngle: float -> unit
        /// Removes a child from this one
        abstract removeChild: child: EngineObject -> unit
        /// <summary>Set how this object collides</summary>
        /// <param name="collideSolidObjects">- Does it collide with solid objects</param>
        /// <param name="isSolid">- Does it collide with and block other objects (expensive in large numbers)</param>
        /// <param name="collideTiles">- Does it collide with the tile collision</param>
        abstract setCollision: ?collideSolidObjects: bool * ?isSolid: bool * ?collideTiles: bool -> unit
        abstract collideSolidObjects: bool with get, set
        abstract isSolid: bool with get, set
        /// Returns string containg info about this object for debugging
        abstract toString: unit -> string

    /// LittleJS Object Base Object Class
    /// - Top level object class used by the engine
    /// - Automatically adds self to object list
    /// - Will be updated and rendered each frame
    /// - Renders as a sprite from a tilesheet by default
    /// - Can have color and addtive color applied
    /// - 2D Physics and collision system
    /// - Sorted by renderOrder
    /// - Objects can have children attached
    /// - Parents are updated before children, and set child transform
    /// - Call destroy() to get rid of objects
    /// 
    /// The physics system used by objects is simple and fast with some caveats...
    /// - Collision uses the axis aligned size, the object's rotation angle is only for rendering
    /// - Objects are guaranteed to not intersect tile collision from physics
    /// - If an object starts or is moved inside tile collision, it will not collide with that tile
    /// - Collision for objects can be set to be solid to block other objects
    /// - Objects may get pushed into overlapping other solid objects, if so they will push away
    /// - Solid objects are more performance intensive and should be used sparingly
    type [<AllowNullLiteral>] EngineObjectStatic =
        /// <summary>Create an engine object and adds it to the list of objects</summary>
        /// <param name="size">- World space size of the object</param>
        /// <param name="tileIndex">- Tile to use to render object (-1 is untextured)</param>
        /// <param name="tileSize">- Size of tile in source pixels</param>
        /// <param name="angle">- Angle the object is rotated by</param>
        /// <param name="color">- Color to apply to tile when rendered</param>
        /// <param name="renderOrder">- Objects sorted by renderOrder before being rendered</param>
        [<Emit "new $0($1...)">] abstract Create: ?pos: Vector2 * ?size: Vector2 * ?tileIndex: float * ?tileSize: Vector2 * ?angle: float * ?color: Color * ?renderOrder: float -> EngineObject

    /// Font Image Object - Draw text on a 2D canvas by using characters in an image
    /// - 96 characters (from space to tilde) are stored in an image
    /// - Uses a default 8x8 font if none is supplied
    /// - You can also use fonts from the main tile sheet
    type [<AllowNullLiteral>] FontImage =
        abstract image: obj option with get, set
        abstract tileSize: Vector2 with get, set
        abstract paddingSize: Vector2 with get, set
        abstract startTileIndex: float with get, set
        abstract context: CanvasRenderingContext2D with get, set
        /// Draw text in world space using the image font
        abstract drawText: text: string * pos: Vector2 * ?scale: float * ?center: bool -> unit
        /// Draw text in screen space using the image font
        abstract drawTextScreen: text: string * pos: Vector2 * ?scale: float * ?center: bool -> unit

    /// Font Image Object - Draw text on a 2D canvas by using characters in an image
    /// - 96 characters (from space to tilde) are stored in an image
    /// - Uses a default 8x8 font if none is supplied
    /// - You can also use fonts from the main tile sheet
    type [<AllowNullLiteral>] FontImageStatic =
        /// <summary>Create an image font</summary>
        /// <param name="image">- Image for the font, if undefined default font is used</param>
        /// <param name="tileSize">- Size of the font source tiles</param>
        /// <param name="paddingSize">- How much extra space to add between characters</param>
        /// <param name="startTileIndex">- Tile index in image where font starts</param>
        /// <param name="context">- context to draw to</param>
        [<Emit "new $0($1...)">] abstract Create: ?image: HTMLImageElement * ?tileSize: Vector2 * ?paddingSize: Vector2 * ?startTileIndex: float * ?context: CanvasRenderingContext2D -> FontImage

    /// Sound Object - Stores a zzfx sound for later use and can be played positionally
    /// 
    /// <a href=https://killedbyapixel.github.io/ZzFX/>Create sounds using the ZzFX Sound Designer.</a>
    type [<AllowNullLiteral>] Sound =
        abstract range: float with get, set
        abstract taper: float with get, set
        abstract randomness: obj option with get, set
        abstract sampleChannels: ResizeArray<ResizeArray<obj option>> with get, set
        abstract sampleRate: float with get, set
        /// <summary>Play the sound</summary>
        /// <param name="pos">- World space position to play the sound, sound is not attenuated if null</param>
        /// <param name="volume">- How much to scale volume by (in addition to range fade)</param>
        /// <param name="pitch">- How much to scale pitch by (also adjusted by this.randomness)</param>
        /// <param name="randomnessScale">- How much to scale randomness</param>
        /// <param name="loop">- Should the sound loop</param>
        abstract play: ?pos: Vector2 * ?volume: float * ?pitch: float * ?randomnessScale: float * ?loop: bool -> AudioBufferSourceNode
        abstract source: U2<float, AudioBufferSourceNode> with get, set
        /// Stop the last instance of this sound that was played
        abstract stop: unit -> unit
        /// <summary>Play the sound as a note with a semitone offset</summary>
        /// <param name="semitoneOffset">- How many semitones to offset pitch</param>
        /// <param name="pos">- World space position to play the sound, sound is not attenuated if null</param>
        /// <param name="volume">- How much to scale volume by (in addition to range fade)</param>
        abstract playNote: semitoneOffset: float * ?pos: Vector2 * ?volume: float -> AudioBufferSourceNode
        /// Get how long this sound is in seconds
        abstract getDuration: unit -> float
        /// Check if the last instance of this sound is playing
        abstract isPlaying: unit -> bool
        /// Check if sound is loading, for sounds fetched from a url
        abstract isLoading: unit -> bool

    /// Sound Object - Stores a zzfx sound for later use and can be played positionally
    /// 
    /// <a href=https://killedbyapixel.github.io/ZzFX/>Create sounds using the ZzFX Sound Designer.</a>
    type [<AllowNullLiteral>] SoundStatic =
        /// <summary>Create a sound object and cache the zzfx samples for later use</summary>
        /// <param name="zzfxSound">- Array of zzfx parameters, ex. [.5,.5]</param>
        /// <param name="range">- World space max range of sound, will not play if camera is farther away</param>
        /// <param name="taper">- At what percentage of range should it start tapering off</param>
        [<Emit "new $0($1...)">] abstract Create: zzfxSound: ResizeArray<obj option> * ?range: float * ?taper: float -> Sound

    /// Music Object - Stores a zzfx music track for later use
    /// 
    /// <a href=https://keithclark.github.io/ZzFXM/>Create music with the ZzFXM tracker.</a>
    type [<AllowNullLiteral>] Music =
        inherit Sound
        abstract sampleChannels: ResizeArray<obj option> with get, set
        /// <summary>Play the music</summary>
        /// <param name="volume">- How much to scale volume by</param>
        /// <param name="loop">- True if the music should loop</param>
        abstract play: ?volume: float * ?loop: bool -> AudioBufferSourceNode

    /// Music Object - Stores a zzfx music track for later use
    /// 
    /// <a href=https://keithclark.github.io/ZzFXM/>Create music with the ZzFXM tracker.</a>
    type [<AllowNullLiteral>] MusicStatic =
        /// <summary>Create a music object and cache the zzfx music samples for later use</summary>
        /// <param name="zzfxMusic">- Array of zzfx music parameters</param>
        [<Emit "new $0($1...)">] abstract Create: zzfxMusic: ResizeArray<obj option> -> Music

    /// Tile layer data object stores info about how to render a tile
    type [<AllowNullLiteral>] TileLayerData =
        abstract tile: float with get, set
        abstract direction: float with get, set
        abstract mirror: bool with get, set
        abstract color: Color with get, set
        /// Set this tile to clear, it will not be rendered
        abstract clear: unit -> unit

    /// Tile layer data object stores info about how to render a tile
    type [<AllowNullLiteral>] TileLayerDataStatic =
        /// <summary>Create a tile layer data object, one for each tile in a TileLayer</summary>
        /// <param name="tile">- The tile to use, untextured if undefined</param>
        /// <param name="direction">- Integer direction of tile, in 90 degree increments</param>
        /// <param name="mirror">- If the tile should be mirrored along the x axis</param>
        /// <param name="color">- Color of the tile</param>
        [<Emit "new $0($1...)">] abstract Create: ?tile: float * ?direction: float * ?mirror: bool * ?color: Color -> TileLayerData

    /// Tile layer object - cached rendering system for tile layers
    /// - Each Tile layer is rendered to an off screen canvas
    /// - To allow dynamic modifications, layers are rendered using canvas 2d
    /// - Some devices like mobile phones are limited to 4k texture resolution
    /// - So with 16x16 tiles this limits layers to 256x256 on mobile devices
    type [<AllowNullLiteral>] TileLayer =
        inherit EngineObject
        abstract canvas: HTMLCanvasElement with get, set
        abstract context: CanvasRenderingContext2D with get, set
        abstract scale: Vector2 with get, set
        abstract data: ResizeArray<TileLayerData> with get, set
        /// <summary>Set data at a given position in the array</summary>
        /// <param name="data">- Data to set</param>
        /// <param name="redraw">- Force the tile to redraw if true</param>
        abstract setData: layerPos: obj option * data: TileLayerData * ?redraw: bool -> unit
        /// <summary>Get data at a given position in the array</summary>
        /// <param name="layerPos">- Local position in array</param>
        abstract getData: layerPos: Vector2 -> TileLayerData
        /// Draw all the tile data to an offscreen canvas
        /// - This may be slow in some browsers
        abstract redraw: unit -> unit
        /// <summary>Call to start the redraw process</summary>
        /// <param name="clear">- Should it clear the canvas before drawing</param>
        abstract redrawStart: ?clear: bool -> unit
        abstract savedRenderSettings: ResizeArray<U4<float, HTMLCanvasElement, CanvasRenderingContext2D, Vector2>> with get, set
        /// Call to end the redraw process
        abstract redrawEnd: unit -> unit
        /// Draw the tile at a given position
        abstract drawTileData: layerPos: Vector2 -> unit
        /// Draw all the tiles in this layer
        abstract drawAllTileData: unit -> unit
        /// Draw directly to the 2D canvas in world space (bipass webgl)
        abstract drawCanvas2D: pos: Vector2 * size: Vector2 * ?angle: float * ?mirror: bool * drawFunction: Function -> unit
        /// Draw a tile directly onto the layer canvas
        abstract drawTile: pos: Vector2 * ?size: Vector2 * ?tileIndex: float * ?tileSize: Vector2 * ?color: Color * ?angle: float * ?mirror: bool -> unit
        /// Draw a rectangle directly onto the layer canvas
        abstract drawRect: pos: Vector2 * ?size: Vector2 * ?color: Color * ?angle: float -> unit

    /// Tile layer object - cached rendering system for tile layers
    /// - Each Tile layer is rendered to an off screen canvas
    /// - To allow dynamic modifications, layers are rendered using canvas 2d
    /// - Some devices like mobile phones are limited to 4k texture resolution
    /// - So with 16x16 tiles this limits layers to 256x256 on mobile devices
    type [<AllowNullLiteral>] TileLayerStatic =
        /// <summary>Create a tile layer object</summary>
        /// <param name="size">- World space size</param>
        /// <param name="tileSize">- Size of tiles in source pixels</param>
        /// <param name="scale">- How much to scale this layer when rendered</param>
        /// <param name="renderOrder">- Objects sorted by renderOrder before being rendered</param>
        [<Emit "new $0($1...)">] abstract Create: pos: obj option * ?size: Vector2 * ?tileSize: Vector2 * ?scale: Vector2 * ?renderOrder: float -> TileLayer

    /// Particle Emitter - Spawns particles with the given settings
    type [<AllowNullLiteral>] ParticleEmitter =
        inherit EngineObject
        abstract emitSize: float with get, set
        abstract emitTime: float with get, set
        abstract emitRate: float with get, set
        abstract emitConeAngle: float with get, set
        abstract colorStartA: Color with get, set
        abstract colorStartB: Color with get, set
        abstract colorEndA: Color with get, set
        abstract colorEndB: Color with get, set
        abstract randomColorLinear: bool with get, set
        abstract particleTime: float with get, set
        abstract sizeStart: float with get, set
        abstract sizeEnd: float with get, set
        abstract speed: float with get, set
        abstract angleSpeed: float with get, set
        abstract particleConeAngle: float with get, set
        abstract fadeRate: float with get, set
        abstract randomness: float with get, set
        abstract collideTiles: bool with get, set
        abstract additive: bool with get, set
        abstract localSpace: bool with get, set
        abstract trailScale: float with get, set
        abstract emitTimeBuffer: float with get, set
        /// Spawn one particle
        abstract emitParticle: unit -> Particle

    /// Particle Emitter - Spawns particles with the given settings
    type [<AllowNullLiteral>] ParticleEmitterStatic =
        /// <summary>Create a particle system with the given settings</summary>
        /// <param name="angle">- Angle to emit the particles</param>
        /// <param name="emitSize">- World space size of the emitter (float for circle diameter, vec2 for rect)</param>
        /// <param name="emitTime">- How long to stay alive (0 is forever)</param>
        /// <param name="emitRate">- How many particles per second to spawn, does not emit if 0</param>
        /// <param name="emitConeAngle">- Local angle to apply velocity to particles from emitter</param>
        /// <param name="tileIndex">- Index into tile sheet, if <0 no texture is applied</param>
        /// <param name="tileSize">- Tile size for particles</param>
        /// <param name="colorStartA">- Color at start of life 1, randomized between start colors</param>
        /// <param name="colorStartB">- Color at start of life 2, randomized between start colors</param>
        /// <param name="colorEndA">- Color at end of life 1, randomized between end colors</param>
        /// <param name="colorEndB">- Color at end of life 2, randomized between end colors</param>
        /// <param name="particleTime">- How long particles live</param>
        /// <param name="sizeStart">- How big are particles at start</param>
        /// <param name="sizeEnd">- How big are particles at end</param>
        /// <param name="speed">- How fast are particles when spawned</param>
        /// <param name="angleSpeed">- How fast are particles rotating</param>
        /// <param name="damping">- How much to dampen particle speed</param>
        /// <param name="angleDamping">- How much to dampen particle angular speed</param>
        /// <param name="gravityScale">- How much does gravity effect particles</param>
        /// <param name="particleConeAngle">- Cone for start particle angle</param>
        /// <param name="fadeRate">- How quick to fade in particles at start/end in percent of life</param>
        /// <param name="randomness">- Apply extra randomness percent</param>
        /// <param name="collideTiles">- Do particles collide against tiles</param>
        /// <param name="additive">- Should particles use addtive blend</param>
        /// <param name="randomColorLinear">- Should color be randomized linearly or across each component</param>
        /// <param name="renderOrder">- Render order for particles (additive is above other stuff by default)</param>
        /// <param name="localSpace">- Should it be in local space of emitter (world space is default)</param>
        [<Emit "new $0($1...)">] abstract Create: pos: obj option * ?angle: float * ?emitSize: float * ?emitTime: float * ?emitRate: float * ?emitConeAngle: float * ?tileIndex: float * ?tileSize: Vector2 * ?colorStartA: Color * ?colorStartB: Color * ?colorEndA: Color * ?colorEndB: Color * ?particleTime: float * ?sizeStart: float * ?sizeEnd: float * ?speed: float * ?angleSpeed: float * ?damping: float * ?angleDamping: float * ?gravityScale: float * ?particleConeAngle: float * ?fadeRate: float * ?randomness: float * ?collideTiles: bool * ?additive: bool * ?randomColorLinear: bool * ?renderOrder: float * ?localSpace: bool -> ParticleEmitter

    /// Particle Object - Created automatically by Particle Emitters
    type [<AllowNullLiteral>] Particle =
        inherit EngineObject

    /// Particle Object - Created automatically by Particle Emitters
    type [<AllowNullLiteral>] ParticleStatic =
        /// <summary>Create a particle with the given settings</summary>
        /// <param name="tileIndex">- Tile to use to render, untextured if -1</param>
        /// <param name="tileSize">- Size of tile in source pixels</param>
        /// <param name="angle">- Angle to rotate the particle</param>
        [<Emit "new $0($1...)">] abstract Create: pos: obj option * ?tileIndex: float * ?tileSize: Vector2 * ?angle: float -> Particle

    /// Medal Object - Tracks an unlockable medal
    type [<AllowNullLiteral>] Medal =
        abstract id: float with get, set
        abstract name: string with get, set
        abstract description: string with get, set
        abstract icon: string with get, set
        abstract image: HTMLImageElement with get, set
        /// Unlocks a medal if not already unlocked
        abstract unlock: unit -> unit
        abstract unlocked: float with get, set
        /// <summary>Render a medal</summary>
        /// <param name="hidePercent">- How much to slide the medal off screen</param>
        abstract render: ?hidePercent: float -> unit
        /// <summary>Render the icon for a medal</summary>
        /// <param name="size">- Screen space size</param>
        abstract renderIcon: pos: obj option * ?size: float -> unit
        abstract storageKey: unit -> string

    /// Medal Object - Tracks an unlockable medal
    type [<AllowNullLiteral>] MedalStatic =
        /// <summary>Create an medal object and adds it to the list of medals</summary>
        /// <param name="id">- The unique identifier of the medal</param>
        /// <param name="name">- Name of the medal</param>
        /// <param name="description">- Description of the medal</param>
        /// <param name="icon">- Icon for the medal</param>
        /// <param name="src">- Image location for the medal</param>
        [<Emit "new $0($1...)">] abstract Create: id: float * name: string * ?description: string * ?icon: string * ?src: string -> Medal

    /// Newgrounds API wrapper object
    type [<AllowNullLiteral>] Newgrounds =
        abstract app_id: float with get, set
        abstract cipher: string with get, set
        abstract host: string with get, set
        abstract cryptoJS: obj option with get, set
        abstract session_id: string with get, set
        abstract medals: obj option with get, set
        abstract scoreboards: obj option with get, set
        /// <summary>Send message to unlock a medal by id</summary>
        /// <param name="id">- The medal id</param>
        abstract unlockMedal: id: float -> obj option
        /// <summary>Send message to post score</summary>
        /// <param name="id">- The scoreboard id</param>
        /// <param name="value">- The score value</param>
        abstract postScore: id: float * value: float -> obj option
        /// <summary>Get scores from a scoreboard</summary>
        /// <param name="id">- The scoreboard id</param>
        /// <param name="user">- A user's id or name</param>
        /// <param name="social">- If true, only social scores will be loaded</param>
        /// <param name="skip">- Number of scores to skip before start</param>
        /// <param name="limit">- Number of scores to include in the list</param>
        abstract getScores: id: float * ?user: string * ?social: float * ?skip: float * ?limit: float -> obj option
        /// Send message to log a view
        abstract logView: unit -> obj option
        /// <summary>Send a message to call a component of the Newgrounds API</summary>
        /// <param name="component">- Name of the component</param>
        /// <param name="parameters">- Parameters to use for call</param>
        /// <param name="async">- If true, don't wait for response before continuing (avoid stall)</param>
        abstract call: ``component``: string * ?parameters: obj * ?async: bool -> obj option
        abstract CryptoJS: unit -> obj option

    /// Newgrounds API wrapper object
    type [<AllowNullLiteral>] NewgroundsStatic =
        /// <summary>Create a newgrounds object</summary>
        /// <param name="app_id">- The newgrounds App ID</param>
        /// <param name="cipher">- The encryption Key (AES-128/Base64)</param>
        [<Emit "new $0($1...)">] abstract Create: app_id: float * ?cipher: string -> Newgrounds

    type AudioBufferSourceNode = System.Object
    type CanvasImageSource = System.Object
    type SpeechSynthesisUtterance = System.Object

