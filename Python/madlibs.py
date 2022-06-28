# SPDX-FileCopyrightText: Copyright (c) 2021 Sam W
# SPDX-FileCopyrightText: Copyright (c) 2021 Shruti Solani
#
# SPDX-License-Identifier: MIT

import random
print("Title : Eat, Drink, And Be Sick")

#input nouns
noun = []
for i in range(4):
    n = input("Enter noun : ")
    noun.append(n)

#input plurals
plural = []
for i in range(6):
    pn = input("Enter plural noun : ")
    plural.append(pn)

#input adjectives
adjective = []
for i in range(2):
    a = input("Enter adjective : ")
    adjective.append(a)

adverb = input("Enter adverb : ")
letter = input("Enter any letter : ")
body_part = input("Enter any body part : ")

print("An inspector from the Department of Health and ", "\u0332".join(random.choice(noun)) , " Services paid a surprise visit to our " , "\u0332".join(random.choice(adjective)) , " school cafeteria.")
print("The lunch special, prepared by our " , "\u0332".join(random.choice(adjective)) , "dietician, was spaghetti and " , "\u0332".join(random.choice(noun)) , " balls with a choice of either a " , random.choice(noun) , " salad or French " , random.choice(plural) , ".")
print("The inspector found the meat-" , "\u0332".join(random.choice(plural)) , " to be overcooked and discovered a live " , "\u0332".join(random.choice(noun)) , " in the fries,causing him to have a " + body_part + " ache.")
print("In response, he threw up all over his " , "\u0332".join(random.choice(plural)) , ".")
print("In his report, the inspector " + "\u0332".join(adverb) + " recommended that the school cafeteria serve only nutritious " , "\u0332".join(random.choice(plural)) , " as well as low-calorie " , random.choice(plural) , " and that all of the saturated " , random.choice(plural) , " be eliminated.")
print("He rated the cafeteria a " + "\u0332".join(letter) + "-minus.")
