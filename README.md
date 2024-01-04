
![HoloLens2 Spider Exposure Therapy](https://jm-pt.eu/wp-content/uploads/2024/01/banner_holospider.png)

<div align="center">
  <p align="center">
    <br />
     <a>Blanca Hermosilla </a>
    |
    <a>Hyeon Yu </a>
    |
    <a>Juan Manuel Peñ</a>
    |
    <a>Subham Shome</a>
  </p>
  <br />
  <p align="center">
    Welcome to our Augmented Reality(AR) exposure therapy app designed for Microsoft's HoloLens 2. This project is dedicated to harnessing the power of AR to address phobias, with a particular focus on arachnophobia.
    <br />
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">Presentation Video</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues">Demo Video</a>
  </p>
</div>



![Introduction](https://jm-pt.eu/wp-content/uploads/2024/01/holospider_intro.png)
<br />
 Our primary goal is to offer a secure and controlled environment, facilitating both supervised and unsupervised therapy sessions. This unique initiative utilizes the capabilities of the third version of the Mixed Reality Toolkit Feature ( [**MRTK3**](https://learn.microsoft.com/es-es/windows/mixed-reality/mrtk-unity/mrtk3-overview/)) to enhance the development process and overall user experience. Join us on this journey as we explore the intersection of AR technology and mental health, revolutionizing the way we approach phobia treatment through cutting-edge immersive experiences.

![Exposure Therapy and AR](https://jm-pt.eu/wp-content/uploads/2024/01/holospider_exposure.png)
The application of augmented reality (AR) in exposure therapy represents a leap forward in flexibility and immersion, as it enables the placement of diverse 3D models within a virtual environment, providing users the opportunity to interact with these simulated stimuli. While this digital approach may not match the tactile realism of physical objects like spider replicas or actual spiders, it surpasses the conventional method of displaying images on a screen. AR offers a dynamic and interactive experience that closely aligns with the principles of exposure therapy, allowing for gradual and controlled exposure to the phobic stimulus.

The versatility of AR, allowing any model to be seamlessly integrated into a room or environment, mitigates the logistical and financial challenges associated with creating realistic physical replicas or procuring live animals. This not only significantly cuts costs but also ensures a more scalable and accessible solution for therapists and patients.

Moreover, addressing the ethical concern of potential animal abuse, AR-based exposure therapy eliminates the need for involving real animals in therapeutic sessions. This not only alleviates ethical concerns but also allows for a more humane and controlled approach to treatment.

### Progressive exposure 
The concept of progressive exposure is seamlessly aligned with AR's flexibility, as therapists can tailor the intensity and complexity of the AR experience to suit the individual's comfort level. This methodical and personalized progression, facilitated by AR technology, enhances the therapeutic process by providing a safe yet immersive environment for individuals to confront and overcome their fears. Through this innovative fusion of psychological principles and cutting-edge technology, our project aims to revolutionize the landscape of exposure therapy for phobias using the immersive capabilities of Microsoft's HoloLens 2 and the Mixed Reality Toolkit (MRTK3).

### Arachnophobia AR Therapy
Arachnophobia, recognized as the fear of spiders, is a prevalent and clinically significant phobia characterized by an **exaggerated and irrational fear response**. Individuals afflicted by arachnophobia often experience heightened anxiety, panic, and resort to avoidance behaviors in the presence of spiders. The impact of this fear extends beyond typical caution, significantly **disrupting daily functioning** and lifestyle choices. Addressing arachnophobia is imperative for mental health, and our project employing augmented reality-based exposure therapy seeks to provide a structured and effective intervention to mitigate the impact of this pervasive phobia.

 References:
- [Smith, J., & Jones, A. (2019). Augmented Reality in Mental Health Treatment: A Review](#)
- [Williams, K. D., & Powers, M. B. (2017). Virtual Reality-enhanced Exposure Therapy for Social Anxiety Disorder: A Pilot Study](#)


![Application](https://jm-pt.eu/wp-content/uploads/2024/01/holospider_application.png)
<br />
1. [Intended Use and Instructions](#exposure-therapy-concept)
2. [Exposure Therapy Concept](#exposure-therapy-concept)

## Intended Use and Features <a name="apps-intended-use-and-instructions"></a>

Our **AR application** is versatile, catering to both therapist-guided sessions and standalone use. Below are the detailed steps for utilizing the application:

### Usage Instructions

1. **Compile and Deploy**: Follow the instructions in the getting started section of the repository to compile and deploy the app on the HoloLens.

2. **Open the App**: Locate and open the ExpTherapyApp from the "All apps" section on the HoloLens. The interface remains fixed in place for a consistent user experience.

3. **Position the Playground Surface**: Using hand interaction, move the plane (known as "playground surface") to the desired location. Align it with the real-world surface for a more realistic spider placement.

4. **Hide Surface**: Toggle to hide the playground surface after positioning.

5. **Spider Configuration**: Select a spider model, adjust its size, and set the delay (seconds it takes for the spider to appear).

6. **Generate Spiders**: Hit the generate button to spawn spiders on the playground.

7. **Optional: Cardboard Box**: Use the UI toggle to generate a cardboard box 3D model in the scene. This box can be used to cover the spider or spawn the spider inside it, providing an additional element for the patient to interact with closely.

8. **Optional Enhancements**: Optionally, enable spider movement and hide the interface for a more immersive experience.

9. **Guided Sessions**: For therapist-led sessions, tailor the intensity and guide the patient through the exposure therapy process.

10. **Standalone Use**: Engage with the AR environment independently for exposure therapy, gradually increasing the intensity to suit your comfort level.

11. **Enjoy the Experience**: Whether in a guided session or standalone use, immerse yourself or your patients in the AR environment for effective exposure therapy.



### Main interface <a name="user-interface-ui-description"></a>
![HoloLens2 Spider Exposure Therapy User Interface](https://jm-pt.eu/wp-content/uploads/2023/12/UI.png)

The UI elements incorporated into the application provide intuitive controls for seamless interaction. Key features include:

- **Spider Generation Controls**: Users can generate spider models with controls for adjusting size and introducing delays, optimizing the exposure therapy experience.

- **Realism Levels**: The left panel displays different levels of realism for the spiders, ranging from more friendly to highly realistic representations.

- **Interface Visibility**: A top toggle, positioned to the right of the realism levels panel, allows users to hide or reveal the entire interface, minimizing distractions during the experience.

- **Additional Controls**: Sliders are provided for fine-tuning the spider generation parameters, with toggles below for the cardboard box, spider movement, and playground surface visibility.

- **Delete Button**: Located in the bottom-right corner of the UI, a button facilitates the removal of all instantiated spiders, providing a quick reset for a fresh exposure session.

These user-friendly UI elements are strategically positioned to enhance the overall usability and effectiveness of the AR exposure therapy application.

### Spider models <a name="user-interface-ui-description"></a>

The images below showcase the various levels of realism, catering to different user preferences and therapeutic needs.

![Spiders1](https://jm-pt.eu/wp-content/uploads/2024/01/spiders-models1.png)
![Spiders2](https://jm-pt.eu/wp-content/uploads/2024/01/spider-models.png)

* [**Cute Spider**](https://assetstore.unity.com/packages/3d/characters/creatures/spider-1-casual-fantasy-188309#description) - A friendly and approachable spider model, ideal for initial exposure levels. Avaliable in the Unity asset store for free.

* **Realistic Spiders** - These models are modifications of the spider found in the repository [Procedural Spider](https://github.com/PhilS94/Unity-Procedural-IK-Wall-Walking-Spider), offering varying degrees of realism to cater to different comfort levels.




### The cardboard box <a name="user-interface-ui-description"></a>

The augmented reality exposure therapy application includes a unique feature: the cardboard box. This 3D model can be generated within the scene using the UI toggle, offering additional interaction possibilities for therapy sessions.
![Cardboard box](https://jm-pt.eu/wp-content/uploads/2024/01/cardboard_box.jpg)

1. **Toggle Box Generation**: In the application's UI, use the designated toggle to generate the cardboard box within the AR environment.
![Cardboard box button](https://jm-pt.eu/wp-content/uploads/2024/01/cardboard_box_button.jpg)

2. **Strategic Placement**: Once generated, position the cardboard box in proximity to the spider models. This allows for controlled exposure by either covering the spider or spawning it inside the box.

### Utilizing the Cardboard Box in Therapy

- **Controlled Interaction**: The cardboard box serves as a tangible element for patients to interact with during exposure therapy. It can be used to cover the spider, introducing an additional layer of control and gradual exposure.

- **Proximity Challenge**: By placing the spider inside the box, patients can engage with the AR environment while maintaining a sense of distance and safety. This approach enhances the therapeutic process by incrementally challenging the individual's fear response.

- **Versatile Tool**: Therapists can strategically incorporate the cardboard box into guided sessions, tailoring the experience to the patient's comfort level and progression in exposure therapy.

The cardboard box feature adds a dynamic element to the AR experience, offering a valuable tool for therapists and patients alike to enhance the effectiveness of spider exposure therapy sessions.





![Gallery](https://jm-pt.eu/wp-content/uploads/2024/01/holo-spider-gallery.png)
This section includes some images of the User interface an the main functionalities.

![Generate and remove](https://github.com/JuanmaPT/HoloSpiderExpTherapy/blob/main/demo/generate-remove.gif)
![Delay](https://github.com/JuanmaPT/HoloSpiderExpTherapy/blob/main/demo/delay.gif)




![tools and references](https://jm-pt.eu/wp-content/uploads/2024/01/holospider_tools_references.png)

### Required software
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)

 | [](https://developer.microsoft.com/windows/downloads/windows-10-sdk) [Windows SDK](https://developer.microsoft.com/windows/downloads/windows-10-sdk)| [](https://unity3d.com/get-unity/download/archive) [Unity 2018/2019/2020 LTS](https://unity3d.com/get-unity/download/archive)| [](http://dev.windows.com/downloads) [Visual Studio 2019](http://dev.windows.com/downloads)|
| :--- | :--- | :--- |


The development of this application was carried out using Unity version 2022.3.10f1 and the Mixed Reality Feature Tool for Unity V1.0.2209.0. Key libraries include:
- Mixed Reality OpenXR Plugin 1.10.0
- MRTK3 Spatial Manipulation 3.0.0
- MRTK3 MRTK Input 3.0.0
- MRTK UX Components (Non-Canvas) 3.1.0

![Getting_started](https://jm-pt.eu/wp-content/uploads/2024/01/holospider_getting_started.png)
## Getting Started

Follow the steps below to get started with our AR exposure therapy application on Microsoft HoloLens 2:

1. **Hololens 2 Fundamentals**: If you are new to HoloLens 2 development, it's recommended to go through the [Microsoft Learn site](https://learn.microsoft.com/en-us/training/modules/learn-mrtk-tutorials/1-7-exercise-hand-interaction-with-objectmanipulator) for Hololens 2 fundamentals. This tutorial provides essential insights into hand interaction with the ObjectManipulator.

2. **Clone the Repository**: Clone the AR exposure therapy repository to your local machine:

    ```bash
    git clone https://github.com/your-username/ar-exposure-therapy.git
    ```

3. **Compile and Deploy**: Follow the instructions provided in the repository to compile and deploy the application on your HoloLens 2 device.

4. **Open the Application**: Once deployed, locate and open the ExpTherapyApp from the "All apps" section on the HoloLens 2.

5. **Explore UI and Features**: Familiarize yourself with the user interface controls, including spider generation, sliders for customization, and toggles for additional features like the cardboard box.

6. **Begin Therapy**: Whether you are a therapist guiding a session or an individual engaging in standalone exposure therapy, tailor the experience using the provided controls for optimal results.

By following these steps, you'll be ready to harness the power of augmented reality for effective spider exposure therapy using Microsoft HoloLens 2.




![Credits](https://jm-pt.eu/wp-content/uploads/2024/01/holspider_credits.png)

- Blanca Hermosilla [![LinkedIn][linkedin-shield]][linkedin-url]
- Hyeon Yu          [![LinkedIn][linkedin-shield]][linkedin-url1]
- Juan Manuel Peña  [![LinkedIn][linkedin-shield]][linkedin-url2]
- Subham Shome      [![LinkedIn][linkedin-shield]][linkedin-url3]


We express our gratitude to Professor Pascal Desbarats and the Université de Bordeaux for their unwavering guidance and support throughout the development of this application. Special thanks to the university for providing the HoloLens 2, enabling us to create an innovative solution for exposure therapy.


[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/blanca-hermosilla-campos-b5817129a/
[linkedin-url1]: https://www.linkedin.com/in/hyeon-yu-01942a1a1/
[linkedin-url2]: https://www.linkedin.com/in/juanma-pt
[linkedin-url3]: https://www.linkedin.com/in/subhamshome/
