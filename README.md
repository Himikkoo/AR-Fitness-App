# AR-Based Fitness App

An augmented reality (AR) fitness application that provides interactive workout guidance using 3D models and animations. The app detects planes and objects to trigger relevant AR experiences, making fitness fun and engaging.

---

![Output](AR-Fitness-App/Burpee - SampleScene - Android - Unity 2022.3.21f1_ _DX11_ 2024-05-08 10-51-39.mp4)


## Features

1. **3D Animated Exercises**:  
   - Animated 3D models perform various exercises, including:  
     - Burpees  
     - Jumping Jacks  
     - Squats  
     - Pushups  
     - Bicep Curls  

2. **Plane Detection**:  
   - If a plane is detected in the environment, the 3D model performs exercises in real time.

3. **Object Detection**:  
   - When an image of a dumbbell is detected, a 3D model of a dumbbell is displayed.

4. **Augmented Reality Integration**:  
   - Powered by the **Vuforia Engine**, the app overlays interactive 3D content into the user’s environment.

---

## Technology Stack

### Tools and Frameworks
1. **Blender**:  
   - Used for creating and animating 3D exercise models.
   
2. **Vuforia Engine**:  
   - Enables plane and object detection for AR functionality.

3. **Unity**:  
   - Integrated 3D models and animations with AR features.

4. **Programming Languages**:  
   - C# for scripting within Unity.

---

## How It Works

1. **Plane Detection**:  
   - The app uses the device’s camera to detect flat surfaces.
   - When a plane is detected, a 3D model appears and performs a selected exercise.

2. **Object Detection**:  
   - The app recognizes specific images (e.g., a picture of a dumbbell).
   - Upon recognition, a 3D model of a dumbbell is displayed.

3. **3D Animation**:  
   - The 3D models are animated in Blender to demonstrate proper exercise techniques.

---

## Installation and Setup

### Prerequisites

1. Install **Unity** with the **Vuforia Engine Plugin**.
2. Install **Blender** (for creating or modifying 3D models).

### Steps to Set Up

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/ar-fitness-app.git
   cd ar-fitness-app
2. Open the project in Unity:

Install the Vuforia Engine in Unity through the Package Manager.
Import the 3D models and animations into the Unity scene.
Configure Vuforia:

3. Go to the AR Camera settings in Unity.
   
Add a Vuforia license key in the AR Camera settings.
Set up Image Targets for the dumbbell and configure plane detection for exercise animations.
Build the app:

4. After configuring the Unity scene, build the project for your target platform (Android/iOS).
   
For Android: Ensure you have the correct Android SDK and NDK installed.
For iOS: Make sure you have Xcode installed for building the app.
Test the app:

5. Deploy the app to your mobile device and test the functionality of plane detection and object recognition with the 3D exercise animations.
css
