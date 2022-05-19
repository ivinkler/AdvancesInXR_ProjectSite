# **Sensory Underload**
Ian Vinkler

## Initial Goal

[Initial Proposal Presentation](https://docs.google.com/presentation/d/15AEEFDeUZ1pilrMqrQi1OeVuRq_9CITGk70djZRYxAk/edit?usp=sharing)

The aim of this project is to use VR to explore how we engage with our senses - or more particularly, how we engage with the loss, degredation, or alteration of one of our senses. The project itself will be layed out like a scientific experiment - the user will be guided through a virtual "obstacle course" of sorts, but will have limited or altered  sensory feedback
The basic initial build will focus on these key senses:

### Visual
As somebody with severe near-sightedness, I am interested in using VR to explore how different kinds of visual imparements may affect how somebody engages with and navigates a space. Using VR, we can simulate these to a degree that is not possible in reality. Some examples I wish to explore include:
- Color Blindness
- Near/Far sightedness
- Dyslexia (Technically not a visual impairment, but is visual-based and affects many people)

### Auditory
Our ability to hear is a powerful tool for understanding our environment - and I am curious as to how this works in tandem with or compensates for our visual senses. From the audio perspective, I am interested in exploring:
- Varrying degrees of deafness
- Sound sensitivity
- How auditory feedback can compensate for visual impairment.

## Potential Aplicaitons

I feel this project would be good for promoting empathy for people with disability from those who may have difficulty putting themselves in those situations. I also feel this would be a good way to test how accessible a building layout or design is for people with these types of impairments.
(ie, does navigation of this space rely on color? are warnings posted in ways that somebody with visual impairment or auditory impairment will be made clearly aware of them?)

## State-of-the-Art & Challenges
Much of what I will be doing visually will be on the rendering & post processing side of things - and from the auditory side of things I will be using spatialized audio to give the most true-to-reality feel I can. I will be following the contemporary [research on the subject of simulating medical conditions in VR](https://s3-ap-southeast-2.amazonaws.com/pstorage-wellington-7594921145/22871222/2020McIntoshetalSimulatingImpairmentVR.pdf) [(See also)](https://www.researchgate.net/publication/329741337_Degraded_Reality_Using_VRAR_to_simulate_visual_impairments) 

I feel my greatest challenge will be using Unity’s render pipeline and post-processing to simulate real impairments as closely and accurately as possible. Additionally, I will need to ensure the simulation is not overly complex or over stimulating, as I can imagine the potential for nausea and motion sickness will only increase with altered visuals.

## Progression

### Pre-Development Planning
The planning phase for this project involved the planning of three elements: level layout, impairment design, and challenge design.
My main focus in the design process was making choices to reduce the risk of motion sickness and disorientation while users navigate the level.

**Level Layout:**
- Level design kept euclidian. Lots of straight hallways and square rooms. This makes both the navigation and building of the level relatively simple.
- Level has no verticality, so the user only needs to worry about horizontal navigation.
- Level contains no branching paths (unless explicitly part of a challenge)
- Level is made from prefabricated parts which align to a grid, with the size of each room segment being 2x2x3 meters. This gives the user plenty of space even in the most narrow sections.
- Making the level from prefabricated sections makes it easier to implement features like procedural generation or end-user level creation/editing in the future.

**Impairment Design:**
- Two visual impairments planned: Color Blindness and Myopia
- Both will be implemented using post-processing.
- For things like Myopia, the effect cannot be exremely pronounced as it can increase motion sickness
- Auditory impairment will be implemented using spatialized audio, and adjusting what frequences the user can hear and how well.

**Challenge Design:**
- Challenges should test multiple types of perception when possible
- Challenges should not require complex interaction (Keep it simple: ie, press a button, move to a door, etc.)
- Two kinds of challenges:
  - Passive: User does not need to directly interact with any elements. (Moving to a specfic door, follow a specfic path, find an object, etc)
  - Active: User must engage with interactable elements to complete a task (Press a series of buttons, pick up and move an object, etc.)

**Problems**
- Original design featured a maze section, but this was found to not be conducive to reducing disorientation and motion sickness. Removed.

### Early Development (April 25th Milestone)

[Full Presentation + Images](https://docs.google.com/presentation/d/15oSyVoxtRcjpZ0IZH5rNjJsf_xytUUVrmwLu10GJLOs/edit#slide=id.p)
**General summary of progress:**
- All individual segments of the level modeled
- Map layout planned and built into engine
- Converted from Built-In render pipeline to HDRP
- Post processing settings of Color blind mode and Myopia mode completed
- Rudimentary script to make depth of field dynamic written, not yet fully implemented

**Problems:**
- HDRP handles post processing differently than the built in render pipeline, making adjustments necessary.
- DoF effect requires tweaking to make transition between focal distances less jarring.

### Current State (May 18th Milestone)

[Demo Video](https://drive.google.com/file/d/1gZR2t1sTjqKlwa5IT6IXiJjB5pkhgpMD/view?usp=sharing)
[Full Presentation + Images](https://docs.google.com/presentation/d/1hJuyt_nUczFhHUP6JCWlvo9pvv5WEXVBV6uzIrYImX4/edit#slide=id.p)
General summary of progress:
- Level fully modeled, lit, and collision set up.
- VR Controls and interaction set up
- Event structure set up for implementation of challenges
  - Interaction with buttons
  - Carryable "Instruction" tablet that changes depending on what room you're in (Event triggers not yet implemented)
  - Two challenges (1 passive, 1 active) fully implemented.

**Challenge One: Crossroads**
- Passive challenge, designed to test distance vision and hearing.
- User asked to proceed through one of three doors at the end of 10m hallways, labeled Trap, Tarp, and Harp respectively.
  - Words are designed to either sound or look similar, to make distinguishing between them more difficult.
  - With near-sightedness, user will not be able to identify a door until they have already proceeded down one of the paths.
  - If user has an auditory impairment, they may mishear which door they must proceed towards.
  - Only the correct door will open upon interaction.

**Challenge Two: Long Room**
- Active challenge, designed to test distance vision and color vision.
- User asked to follow instructions projected on a screen at the far end of a long room. At the near end, a series of buttons is present which they must press in sequence to proceed.
  - If the buttons are pressed out of sequence, a buzzer is heard and the sequence resets to the beginning.
  - If the correct buttons are pressed, a chime is heard + a victory fanfare at the completion of the sequence.
  - With near-sightedness, user will not be able read the directions from next to the buttons, and will need to take more time walking over to see the next step.
  - The buttons they need to press are distinguished by color, making it more difficult to identify the correct button in color blind mode.

**Cut Content:**
- Spatial audio not implemented in this build
- Two rooms cut from map design
- Only 2 “challenges” fully functional.
- A lot of the code to make things work is present in the build (Events, behavior scripts, etc), but just has not been implemented into the level yet.)
- No voiceover work for instructions.


**Problems:**
- HDRP not compatible with Oculus Quest 2. Conversions made to URP as a result
  - This unfortunately broke the DoF implementation again. Not yet fixed in this version
- Collision on held objects will sometimes not deactivate, causing the user to be "pushed" by the object they are holding, potentially knocking them out of bounds.
- Time constraints required cutting of certain level segments

# **Utilized Technologies**

### Software:
- Unity Engine
  - Universal Render Pipeline (Rendering and Post-Processing)
  - XR Interaction Toolkit (VR Interaction/Movement)
  - XR Plugin Manager (VR Implementation/Compatibility)
  - Oculus XR Plugin (VR Implementation/Compatibility)
  - Windows XR Plugin (VR Implementation/Compatibility)
  - Virtual HMD (VR Implementation Testing)
- Packages and Assets:
  - [Surfaces Lite](https://assetstore.unity.com/packages/2d/textures-materials/surfaces-lite-89739) (Materials and Textures)
  - [Oculus Integration](https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022) (Compatibility)
- Adapted code from tutorials by Youtuber [VR With Andrew](https://www.youtube.com/watch?v=pmRwhE2hQ9g)
- Audio from [Mixkit](https://mixkit.co/)
- Values used for Post Processing code adapted from [jsColorblindSimulator](https://github.com/MaPePeR/jsColorblindSimulator/blob/master/colorblind.js)
- [Steam Audio](https://valvesoftware.github.io/steam-audio/) (Present but not Implemented)

### Hardware:
- HMD: Oculus Quest 2 VR Headset (Using "Air Link" connection feature)
- PC: Build with Intel i7 Processor and Nvidia RTX 30 series GPU

# **Minimum Viable Product (Pre Development)**
- Single navigable level for player to explore and interact with in VR
  - Main base layout by 25th
- Implementation of initial audio & visual impairments
  - Implementation of near/far sightedness by 25th
- Script & tasks to guide player through the course
- Timer/Score system to grade how well user navigates the level

# **Current Prototype (Post Development)**
- Fully navigable level complete with lighting, colision, textures, and materials.
- Color Blind Mode fully implemented (Development side, not adjustable on user's end.)
- Base scripts for tasks and interaction are present, but not every challenge has been implemented.
- Text script for instructions completed in code, but no audio recorded.
- A single passive and active challenge have been implemented with full functionality.

# **Future Development**
## Initial Outlook:
- Implementation of haptics to simulate more senses
- Implementation of further visual and auditory impairments
- Creation of more courses
  - Procedural generation?
- More specific objectives & tasks within the courses
  - Find an object?
  - Escort an NPC?
  - Perform a complex task?
  
## Outlook at May 18th Milestone:
Hopefully I will be able to continue working on this project and implementing the features I originally wanted to.

Next priority would be implementing the remaining visual-based challenges, re-working how the near/far-sightedness impairment works to be better suited for VR, and implementing spatialized audio and sound-based challenges. (All while refining the VR interaction/navigation)
After that? Probably expanding the level and the types of impairments you can have.


