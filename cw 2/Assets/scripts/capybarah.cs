using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capybarah : MonoBehaviour
{
    string HeroName = "gort";
    bool isHero = true;
    int HeroAge = 25;
    int HeroHeight = 56;
    string HeroSuperPower = "unknown";
    int Speed = 35;
    
    string VillainName = "Sharton";
    int VillainAge = 32;
    int VillainHeight = 45;
    string VillainSuperPower = "none";




    // Start is called before the first frame update
    void Start()
    {
        int MaxHeight = HeroHeight + 5;
    
        print("Somewhere very far off into the vast and deep rivers of South America resides a brave animal.");

        print(" A capybara that seldom won a battle.");

        print("His age was " + HeroAge + ", he stood about" + MaxHeight + "cm tall and was said to be incredibly swift with a speed of" + Speed + "KM/H.");

        print("However despite losing so much, he had mysterious abilities that were completely" + HeroSuperPower);

        print(" Having fought over 10,000 battles, he gained a tremendous amount of experience far greater than any warrior of the capybara tribe.");

        print(" Those who observed some of his battles say that it looks as though he deliberately takes hits to enhance his endurance, however this plan of his will soon come to make sense.");

        print(" The other capybaras thought him a loser, a failure not worth being amongst them; so the village council decided to exile him for he could not provide any help for them.");

        print(" After countless hours of training, his power increased and he soon began to assemble his own army. ");

        print("No one in the village believed in him but a few and those who did were all exiled like he was.");

        print("Years have passed and the brave warrior's army kept growing in size and power until one day...");

        print(" The capybara tribe was attacked by " + VillainName + ", a wicked beast whose army exceeded the village's.");

        print(" Sharton was " + VillainAge + " and stood around " + VillainHeight + "cm in height.");

        print("The age difference between our hero and Sharton was " + (VillainAge - HeroAge));

        print("Unlike our hero, however, Sharton had his powers taken away from a young age, leaving him with " + VillainSuperPower);

        print(" Many of the capybara tribe suffered worse than they could imagine and they would continue to suffer lest they summon the strongest army they could find.");

        print(" Suddenly, a mysterious figure followed by many others lurked from the fog near the rivers. That caligo fogged over thier mind and shoved away traumatic and fearful experiences that cradled their thoughts into calmness.");

        print(" It was someone they've abandoned. In spite of all they've done for him, our hero rose from the shadows to shift the tides of the great war.");

        print(" The malefic war ended thanks to our hero, whose legacy lived on and came to be known as " + HeroName + "; the legendary capybara warrior.");
    }
}