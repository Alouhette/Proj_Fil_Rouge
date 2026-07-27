# Proj_Fil_Rouge

## Objectif: 
***-Réaliser un projet de météo**
##

**Étape à suivre:**

***Les étapes seront évolutif, en fonction de l'evolution du Cours***

## 1er Étape: ##

***Modélisation du monde Météorologique***

Nous avons choisi un monde simple, composé d'un sol, d'un arbre qui sera indicateur du changement de la météo en fonction des variations de la temperature à travers l'appel d'une API, puis d'un personna(le testeur portant le casque ou le simulateur du monde) qui subira les changements de temperature et de saison.

## 2nd Étape: ##

**Organisation de la scène**
Nous avons choisis la scène principal(Basic URP) se nommant **SampleScene**.

*Sol:* 
Nous avons décomposé le sol en 2 parties deux sol, contenu dans le l'objet **Ground** se nommant **Dirt** et **Dirt 2**

*Arbre:*
Nous avons aussi choisis, un arbre qui nous indiquera le changement de saison, et les variations de nature externe, qu'ils fassent: pluvieux, neigé, ensolleillé... Illustré par l'objet **Tree** composé :

* D'un tronc se trouvant dans le l'objet ***Wood***
* Des branches illustré dans l'objet **Sunny Leaves** composé de:
* ***Leafs 1***
* ***Leafs 2-1***
* ***Leafs 2-2***
* ***Leafs 3***

*Nature*
-Ce dossier qui contient la simulation de la **Neige** et **Pluie**

(Il possède notamment plusieur  en fonction de la météo)

*Static Block:*
Juste pour servir de support de présentation des pioches, objet immobile, pas d'intéraction possible

*Pickaxe & Blocks:*
Il s'agis d'objet/Prefab pour testers les intéractions avec la VR, la pickaxe sert à frapper les blocs pour tester leurs physique.

**Organisation des Assets:**

Nos dossiers sont organisés de la façon suivante :
* ***Materials*** (pour stockers les matériaux et couleurs de nos objets)
* ***Prefabs*** (pour stockers les Prefabs de nos objets que l'on adapte au besoin)
* ***Scenes*** (pour stocker nos scènes, il n'y en à qu'une pr le moment)
* ***Scripts*** (Bientot pour stocker les scripts relié à nos objets et prefabs)

## 3eme Étape: ##

**Fonctionnalitées**

*Déplacement:*
Joystick gauche : Pour le déplacement
Joystick droit : Pour tourner la Caméra

*Intéractions:*
Possibilité d'attraper une "pickaxe", de la lancer ou encore de l'utiliser pour taper dans les blocks

*Retours:*
Musique de fond (Loop),
Pioche : Sons & vibrations (potentiel bug pour vibration) quand on attrape l'objet

## 4eme Étape: ##

**Intéractions**

Nous avons rajouté des particules systemes pour simuler la neige, et la pluie.
Nous les avons rajouter un script pour les declanché, afin d'observer les changements et l'effet que sa procure.
En parlant des scripts rajouté, comme donné dans le cours nous avons fais un appel à travers l'api météo pour donner la température en temps réel.
Comme tenu de la faible variation de la température nous ferons varions la température pour montrer les cas que nous avons eu à décidé mais lors du rapport,
la température sera donné à partir de l'appel de l'API.

Nous comptons aussi exploité l'API pour donner une information sur  la pluviometrie, la chute de neige ou même l'etat du soleil, mais pour le moment une température
négative est considéré comme neigeux, positif pluvieux.


**Sons**

Nous avons rajouté du son qui rythme avec la simulation, et tout marche bien.


