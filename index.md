# **Sensory Underload**
Ian Vinkler

Presentation: https://docs.google.com/presentation/d/15AEEFDeUZ1pilrMqrQi1OeVuRq_9CITGk70djZRYxAk/edit?usp=sharing 

## Initial Goal

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
Much of what I will be doing visually will be on the rendering & post processing side of things - and from the auditory side of things I will be using spatialized audio to give the most true-to-reality feel I can. I will be following the contemporary research on the subject of simulating medical conditions in VR (see: https://s3-ap-southeast-2.amazonaws.com/pstorage-wellington-7594921145/22871222/2020McIntoshetalSimulatingImpairmentVR.pdf and https://www.researchgate.net/publication/329741337_Degraded_Reality_Using_VRAR_to_simulate_visual_impairments) 

I feel my greatest challenge will be using Unity’s render pipeline and post-processing to simulate real impairments as closely and accurately as possible. Additionally, I will need to ensure the simulation is not overly complex or over stimulating, as I can imagine the potential for nausea and motion sickness will only increase with altered visuals.

## Progression
This is where progress on the project will be tracked

# **Utilized Technologies**
## Unity Engine

The project will be built within the Unity Engine and utilize is VR capabilities and API.

## Steam Audio

The project will make use of spatialized audio to simulate the acoustic properties of a real environment and real human hearing.

# **Minimum Viable Product**
- Single navigable level for player to explore and interact with in VR
  - Main base layout by 25th
- Implementation of initial audio & visual impairments
  - Implementation of near/far sightedness by 25th
- Script & tasks to guide player through the course
- Timer/Score system to grade how well user navigates the level

# **Future Development**
- Implementation of haptics to simulate more senses
- Implementation of further visual and auditory impairments
- Creation of more courses
  - Procedural generation?
- More specific objectives & tasks within the courses
  - Find an object?
  - Escort an NPC?
  - Perform a complex task?


