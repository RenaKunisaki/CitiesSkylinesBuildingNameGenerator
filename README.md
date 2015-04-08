Customizable Building Name Generator by wufire
======

New names for residential, industrial, office, and commercial buildings. Add your own names in the mods folder!
Many default names provided by reddit user /u/TPangolin

##Name file location##
###Windows###
```
C:\Users\<username>\AppData\Local\Colossal Order\Cities_Skylines\Addons\Mods\WufireNameGenerator\
```
###Mac###
```
/Users/<username>/Library/Application Support/Colossal Order/Cities_Skylines/Addons/Mods/WufireNameGenerator/
```

If you have trouble finding the Library folder do the following:
* Open Finder and click "Go" on the top bar.
* Press the Option/Alt key on your keyboard and Library will appear in that list.
* Then the rest of the path should be easy to find (I hope!)

###Linux###
(Any Linux users want to help me out here? :D)

##Detailed instructions##
* First activate the mod from the content manager, then start/load a city.
  * The first time the mod is loaded, the default names files are written to the mod location above.
  * These files will be used for name parts whenever a city is loaded.
* The file format is JSON, which you can verify is correct at http://jsonlint.com/

##Name Generation Details##
* A name is generated by pulling a random name from a list of words.
* If multiple lists are provided, the generator will add one word from each list in order.
  * If a list is marked 'optional', it has a 50% chance of being added.
  * If adding the word will be larger than the maximum name limit (32 characters), the word is ignored.
