# discover.medical.dyna-mods
Unity project for displaying dynamic 3D models

## Version
This was made using Unity 3D version 2018.3.0f2 personal available dor download here:
https://store.unity.com/download

> Please note that Unity requires purchase of a pro license if the company makes more than 100k a year through its use.

## Opening and using the project
To open the project simply clone this repo and download unity

Once unity is installed (takes a little bit), you can open the project by double clicking the scene file under: 

**⁨⁨dyna-mods⁩ ▸ ⁨DynaMods - Heart⁩ ▸ ⁨Assets⁩ ▸ Scenes ▸ DynaMods - Heart.unity**

From here you can change, edit mor modify anything you like using the maid editor window, the heiarchy and the scripts.

## Changing the window layout
I recommend switching to the 2 by 3 layout option, this will allow you to see your editor window, play window and project structure very easily 

<img width="429" alt="screen shot 2019-01-04 at 10 41 57 am" src="https://user-images.githubusercontent.com/41008485/50696715-35389d00-100e-11e9-994a-7298868b0daf.png">

## Navigating the heiarchy
To modify the project we will need to modify the heiarchy and the objects within it.
Start by expanding the Canvas > Rotational Axis > Labels / Reference Points

<img width="271" alt="screen shot 2019-01-04 at 10 55 27 am" src="https://user-images.githubusercontent.com/41008485/50697296-d6742300-100f-11e9-9bec-7f20f057001b.png">

Now click on one of the label objects, notice the inspector window on the far right changes:

<img width="878" alt="screen shot 2019-01-04 at 11 01 03 am" src="https://user-images.githubusercontent.com/41008485/50697526-75991a80-1010-11e9-8aa1-043263badb8a.png">

Here is where we msake use of scripts, properties and components. 

You can modify scripts with public variables right in the editor without haveing to go into the actual code, for example, each label has a 'LabelRotate' script, and within that script it has a variable 'Reference Point' which takes another GameObject.

<img width="359" alt="screen shot 2019-01-04 at 11 09 44 am" src="https://user-images.githubusercontent.com/41008485/50697834-5e0e6180-1011-11e9-8754-03995f3b2557.png">

You can change this varaible by clicking and dragging a GameObject from the heiarchy (For example, one of our reference point objects) 

<img width="881" alt="screen shot 2019-01-04 at 11 11 53 am" src="https://user-images.githubusercontent.com/41008485/50697975-c2312580-1011-11e9-8d65-d60c883a8fd8.png">

You can also directly edit the label distance variable which will determine how close to the reference point object the label will appear, you can see the effect of these changes by clicking the play button at the top of the screen. In the image below I increased the aorta label distance:

<img width="1672" alt="screen shot 2019-01-04 at 11 16 47 am" src="https://user-images.githubusercontent.com/41008485/50698203-4e434d00-1012-11e9-8307-b4d4a8779d05.png">

