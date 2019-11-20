Test Assets
===========

Generic placeholder assets for testing/prototyping.

HDRI/Bluesummers Photo Studio.exr
---------------------------------

Environment HDRI, photo studio with umbrella, made by Alejo "Mr. Bluesummers" Grigera.

http://www.mrbluesummers.com/4701/downloads/free-hdri-map-photo-studio-with-umbrella

HDRI/Unity Muir Wood.exr
------------------------

Environment HDRI, woodland with warm sunlight, made by Unity Technologies.

https://assetstore.unity.com/packages/essentials/beta-projects/unity-hdri-pack-72511

Mesh/Teapot.obj
---------------

Utah teapot exported from Houdini.

Texture/UV Grid.png
-------------------

UV test grid texture exported from Blender.

How To Install
--------------

This package uses the [scoped registry] feature to resolve package
dependencies. Please add the following sections to the manifest file
(Packages/manifest.json).

[scoped registry]: https://docs.unity3d.com/Manual/upm-scoped.html

To the `scopedRegistries` section:

```
{
  "name": "Keijiro",
  "url": "https://registry.npmjs.com",
  "scopes": [ "jp.keijiro" ]
}
```

To the `dependencies` section:

```
"jp.keijiro.test-assets": "1.0.1"
```

After changes, the manifest file should look like below:

```
{
  "scopedRegistries": [
    {
      "name": "Keijiro",
      "url": "https://registry.npmjs.com",
      "scopes": [ "jp.keijiro" ]
    }
  ],
  "dependencies": {
    "jp.keijiro.test-assets": "1.0.1",
    ...
```
