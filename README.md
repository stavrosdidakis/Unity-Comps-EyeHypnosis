# Unity-Comps-EyeHypnosis
A Unity composition that displays a hypnotic, reactive, and immersive scene by combining **animated eyes**, **random motion**, and **organic interactions**.

<img src="README/main.gif" alt="Screenshot" width="50%" />

---

## 🌀 Overview

The project features 
- a custom set of randomly positioned **eyes** arranged in a 3D space that constantly track a moving target,
- a **video-textured sphere** that floats around in the scene, creating a dynamic focal point,
- a **randomly flashing light** that add an extra layer of visual dynamism, and
- a camera that orbits around the scene, offering continuous, engaging perspectives.

---

## ✨ Key Components

### 🎥 `OrbitCamera.cs`
- Smoothly orbits the camera around a target object.
- Maintains a constant distance and rotation speed.

### 🕊️ `SmoothFlyMotion.cs`
- Drives the sphere’s organic, randomized movement within a bounded 3D area.
- Uses Perlin noise for natural, smooth direction changes.

### 🌀 `SmoothRandomRotation.cs`
- Rotates objects (like the sphere) in random but smooth and continuous directions.
- Changes direction occasionally for a natural, flowing movement.

### 👁️ `RandomSpawner.cs`
- Spawns multiple copies of the **eye** prefab throughout a 3D area.
- All spawned eyes constantly **look at the moving sphere**.

### 💡 `LightHueRotator.cs`
- Continuously rotates the hue of a light, creating a constantly shifting color cycle.
- Adds an immersive, hypnotic visual accent.

---

## 🚀 How to Use
✅ Open the project in Unity.  
✅ Press **Play** to see the eyes track the dynamically moving sphere.  
✅ Use the **Inspector** to tweak parameters like orbit speed, eye count, and color speed to customize the scene.

---

## 🔧 Technical Summary
- Uses **Perlin noise** to create organic, fluid motion.
- All eyes dynamically track the sphere in real time.
- Light hue cycling for an ever-shifting visual atmosphere.
- Modular components make it easy to customize or expand.

---

## Contributing
This project is intended for exploration and creative experiments in **interactive art**, **hypnotic visuals**, and **procedural animation**. Feel free to fork, adapt, and build on it!

---

## Licensing
This work is dedicated to the public domain under the **Creative Commons CC0 1.0 Universal (CC0 1.0)** license.

**You are free to:**
- **Share** — copy and redistribute the material in any medium or format  
- **Adapt** — remix, transform, and build upon the material for any purpose, even commercially.

**No conditions.** You do not need to give credit or seek permission.

For details, see: [CC0 1.0 Universal](https://creativecommons.org/publicdomain/zero/1.0/)