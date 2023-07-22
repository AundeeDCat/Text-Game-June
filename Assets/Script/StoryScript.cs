using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class StoryScript : MonoBehaviour
{

    public TextMeshProUGUI narration;
    public string script = "Erwin felt the gentle sway of his ship as slowly awoke from his sleep. He yawned, stretching his body and cracking his knuckles to get himself ready for the day. He looked into his mirror, fixing his blonde hair and admiring his own blue eyes. He applied a slime across his body meant to protect his skin from the sun all day. He put on his two piece purple and gold swimsuit and had straps fastening the top half to the bottom half. This was to avoid his shorts coming off if dove into the water. Erwin did some final checks around the ship, making sure it was secured to the dock before he grabbed his speargun and nets and headed into Meltem.";
    public GameObject Pages, MainMenu, Page1, Page2, Page3, Page4, Page5, Page6, Page7, Page8, Page9, Page10, Page11, Page12, Page13, Page14, Page15, Page16, Page17, Page18, Page19, Page20, Ending1, Ending2, Ending3, Ending4;


    // Start is called before the first frame update
    void Start()
    {
        narration.text = script;
        Pages.SetActive(false);
        MainMenu.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        narration.text = script;
    }

    public void Main_Menu()
    {
        Pages.SetActive(false);
        MainMenu.SetActive(true);
        Ending1.SetActive(false);
        Ending2.SetActive(false);
        Ending3.SetActive(false);
        Ending4.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Page_1()
    {
        script = "Erwin felt the gentle sway of his ship as slowly awoke from his sleep. He yawned, stretching his body and cracking his knuckles to get himself ready for the day. He looked into his mirror, fixing his blonde hair and admiring his own blue eyes. He applied a slime across his body meant to protect his skin from the sun all day. He put on his two piece purple and gold swimsuit and had straps fastening the top half to the bottom half. This was to avoid his shorts coming off if dove into the water. Erwin did some final checks around the ship, making sure it was secured to the dock before he grabbed his speargun and nets and headed into Meltem.";
        Pages.SetActive(true);
        Page1.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Page_2()
    {
        script = "Erwin strolled towards the market, peeking at the stalls, looking at the different items. He wanted some of them but they seemed like a luxury.\r\n\r\n“Morning, Erwin. Where you headed today?” A lady greeted as Erwin approached.\r\n\r\n“Wherever Breeze takes me, Seraph. What’s the most in demand today? I want to see what I can do. I kinda want a new challenge.”\r\n\r\n“Already rearing for a new challenge, eh? It’s only been a few weeks since you started.” She remarked, “As usual, the rarer and larger the catch, the higher the pay. I hear there’s a pod of sharkwhales in the west but might be too much to handle without a teams.”\r\n\r\n“If it was just one, maybe, but do you have something else? What about the trading routes, anything they want? I kinda miss mangoes but they’re too expensive right now.”\r\n\r\nSeraph pulled out two lists, \"You might be interested in one of these.\"";
        Page1.SetActive(false);
        Page2.SetActive(true);
        Page3.SetActive(false);
    }

    public void Page_3()
    {
        script = "Erwin took the two lists and browsed through them. One of them was for Shipping job for goods to trade with the neraby archipelago villages. Another was for a Fishing job for specific species down South. Both jobs had low risk of sharkwhales. Which should Erwin pick?";
        Page2.SetActive(false);
        Page3.SetActive(true);
        Page4.SetActive(false);
        Page18.SetActive(false);
    }

    public void Page_4()
    {
        script = "Erwin sailed out far and to open waters. He had tied a long rope to himself and his ship to avoid getting too far from it while he swam. With the special speargun, given to him by his parents, he dove into the water to begin working. The speargun was especially fashioned to catch schools of fish at a time. It had limited range but as the spear is pulled back, it releases a net to quickly catch other fish in the vicinity. Sometimes he’d miss and catch nothing, getting a little upset as he’d have to reload the speargun and its net with nothing extra to put in his ship’s catch containers.";
        Page3.SetActive(false);
        Page4.SetActive(true);
        Page5.SetActive(false);
    }

    public void Page_5()
    {
        script = "The sun was high in the sky. It was noon. Erwin felt exhausted from working but it was at least done. He heaved a heavy sigh, almost moving his boat as the wind left his mouth. He closed his eyes and relaxed, feeling the gentle ocean breeze as softly kissed his face. Everything was so peaceful. It was quiet. Erwin debated on sleeping or going home. ";
        Page4.SetActive(false);
        Page5.SetActive(true);
        Page6.SetActive(false);
    }

    public void Page_6()
    {
        script = "It was to perfect to pass up the opportunity so Erwin decided to sleep instead, leaving himself and his ship to the mercy of the breeze.";
        Page5.SetActive(false);
        Page6.SetActive(true);
        Page7.SetActive(false);
    }

    public void Page_7()
    {
        script = "Erwin awoke to the sound of a bloodcurdling scream, followed by the sound of thrashing water. His eyes adjusted to the light and he tried to make out what was making that noise.\r\n\r\n“Someone help me! I can’t swim!” \r\n\r\nErwin saw someone, a stranger, in the water just before the horizon but something else in the water made his stomach drop. A sharkwhale, a giant one. It could destroy his ship and kill him. No one walks away from sharkwhale that big. He didn't know what to do, whether to face the sharkwhale or leave the stranger to die and save himself.\r\n";
        Page6.SetActive(false);
        Page7.SetActive(true);
        Page8.SetActive(false);
        Page17.SetActive(false);
    }

    public void Page_8()
    {
        script = "The stranger flailed around as if they didn't know how to swim. The sharkwhale took notice, attracted by the movment. It turned around and made a mad swim for the commotion.";
        Page7.SetActive(false);
        Page8.SetActive(true);
        Page9.SetActive(false);
    }

    public void Page_9()
    {
        script = "Erwin began calling out, “I’m coming! Just hang on! Calm down!”\r\n\r\n“I’m over here!” They shouted back, unaware of the danger they were in. \r\n\r\nWhile the ship moved fast, the sharkwhale was still in front of him. The stranger would be swallowed whole by the time he’d get there. He needed to think of something quick. He grabbed his speargun, hesitating whether to shoot the sharkwhale to slow it down or shoot towards the stranger so they could grab it and Erwin could reel them in.";
        Page8.SetActive(false);
        Page9.SetActive(true);
        Page10.SetActive(false);
        Page16.SetActive(false);
    }

    public void Page_10()
    {
        script = "Erwin fired the speargun. The stranger took notice of it landing nearby the, and immediately grabbed on. Erwin reeled the stranger in as quickly as he could but the sharkwhale was relentless, it continued to chase the stranger like a bait on a fishing line. Through some sheer miracle, he managed to get the stranger aboard the ship. ";
        Page9.SetActive(false);
        Page10.SetActive(true);
        Page11.SetActive(false);
    }

    public void Page_11()
    {
        script = "Erwin took a moment to rest. He could feel his body aching and shaking after what happened. He couldn’t even stand and remained on the floor, taking deep breaths.";
        Page10.SetActive(false);
        Page11.SetActive(true);
        Page12.SetActive(false);
    }

    public void Page_12()
    {
        script = "“Thank you.” The stranger muttered with what strength they had left. \r\n\r\n“We’re not out of the water yet. It could come back. That sharkwhale was huge! I don’t think it would give up that easily. None of them do.” Erwin responded through broken breaths.\r\n\r\n“What?” The stranger asked.\r\n\r\nBefore Erwin could respond, the sharkwhale suddenly took a huge bite out of the ship, almost reaching Erwin’s leg. It managed to swim onto the edge of the ship, making it tip. The two held on tight or they’d slide right into its mouth.\r\n";
        Page11.SetActive(false);
        Page12.SetActive(true);
        Page13.SetActive(false);
    }

    public void Page_13()
    {
        script = "“AAAAAAAAAHHHHHHHHHHHH!!!!” The two screamed in terror as it continued to tip the ship even more.\r\n\r\nErwin slipped, almost sliding into the sharkwhale’s mouth but the stranger managed to grab his hands just in time. \r\n\r\n“Duck!” The stranger shouted as they let go of one of Erwin's hands.\r\n\r\n“HOW DOES A DUCK HELP US?!” Erwin exclaimed, fearing for his life as he could feel the sharkwhale’s teeth clamping down just beyond his toes.\r\n\r\n“Dodge!” The stranger commanded as he seemed to form a giant ball of fire in his palm with nothing. \r\n\r\n";
        Page12.SetActive(false);
        Page13.SetActive(true);
        Page14.SetActive(false);
    }

    public void Page_14()
    {
        script = "Erwin followed, ducking down as the stranger threw the fire at the sharkwhale, burning its head. It roared in his pain as it returned to the water. Erwin wasted no time as the ship balanced, turning the sails to catch the wind and make their escape.\r\n\r\nWhen the two have a moment to catch their breath, the stranger introduces themselves as Eru and as gratitude instructs Erwin to go to Mogotsi where Eru can thank him properly.";
        Page13.SetActive(false);
        Page14.SetActive(true);
        Page15.SetActive(false);
    }

    public void Page_15()
    {
        script = "Eru noticed Erwin eyeing some of the coconuts. Eru bought two fresh coconuts that were pulled out of cool icy water. He cut them open and handed one of them to Erwin. \r\n\r\n\"Here, why not rest for a bit before going home.\"\r\n\r\n\"Thanks.\" Erwin took the coconut and happly sipped the cool and refereshing water.\r\n\r\n\"Will you be trading here often?\" Eru asked.\r\n\r\n\"I'm not sure. Maybe... I forgot how much I missed fruits. They're kinda pricery back at home. Also shouldn't I pay for this?\"\r\n\r\n\"It's on me, don't worry. Although the next time you come back for a job, come give me a visit, we could do this again.\"\r\n\r\n\"I'd like that.\" Erwin smiled.";
        Page14.SetActive(false);
        Page15.SetActive(true);
    }

    public void Page_16()
    {
        script = "Erwin fired the speargun. It fails to pierce through the sharkwhale's skin and ricocheted off it. Erwin wouldn't have enough time to reload it as he heard the deafening screams of the stranger as they were eaten by the sharkwhale. Erwin remained perfectly still, wanting to not attract the attention of the sharkwhale. When it was gone, he quietly sailed home, bearing the weight of the guilt from what had happened. ";
        Page9.SetActive(false);
        Page16.SetActive(true);
    }

    public void Page_17()
    {
        script = "Erwin ignored the cries of the stranger as they were eaten, hardening his heart as he quickly turned his ship around. The commotion, however, attracted the attention of the sharkwhale. Erwin tried his best to sail away but the wind was against him. It a matter of moments, the sharkwhale jumped onto his ship, breaking it in half. The ship begun sinking. Erwin jumped into the water, knowing it could be his only chance to escape. He may had been a great swimmer but he was no match for the massive sharkwhale.";
        Page7.SetActive(false);
        Page17.SetActive(true);
    }

    public void Page_18()
    {
        script = "Erwin followed the directions provided, making sure ot be careful to not damage the goods he was transporting. It didn't take him long to find the archipelago. He sailed in close to confirm that village on one of the islands was Mogotsi. As he was getting reading to dock his boat, Eru saw the numerous coconut trees that lined the shore, wondering if he could get some as he hadn't had fruit in a while. But he shook his head, he was there for work purposes. Once the job was done, he could get buy some, for now he had to focus on his task.";
        Page3.SetActive(false);
        Page18.SetActive(true);
        Page19.SetActive(false);
    }

    public void Page_19()
    {
        script = "It didn't take long for Erwin to find the buyer, a farmer named Eru. Eru happened to be waiting at the docks for Erwin.\r\n\r\n\"Oh you're here!\" Eru greeted.\r\n\r\n\"I've got a delivery for someone named Eru, is that you?\"\r\n\r\n\"Sure is. Lucky you caught me on time. I was about ready to sail out to look for Meltem to trade.\"\r\n\r\nErwin looked over at Eru's boat. It didn't seem to seaworthy and its coxswain looked rather inexperienced to sail and find Meltem.\r\n\r\n\"You weren't planning to go to Meltem, were you?\"\r\n\r\n\"I was, actually. But it would have been a terrible plan to be honest. I don't even know how to swim. But I need to trade my produce for money or I won't make it to next season, hence my desperation.\"";
        Page18.SetActive(false);
        Page19.SetActive(true);
        Page20.SetActive(false);
    }

    public void Page_20()
    {
        script = "Eru noticed Erwin eyeing some of the coconuts. Eru bought two fresh coconuts that were pulled out of cool icy water. He cut them open and handed one of them to Erwin. \r\n\r\n\"Here, why not rest for a bit before going home.\"\r\n\r\n\"Thanks.\" Erwin took the coconut and happly sipped the cool and refereshing water.\r\n\r\n\"Will you be trading here often?\" Eru asked.\r\n\r\n\"I'm not sure. Maybe... I forgot how much I missed fruits. They're kinda pricery back at home. Also shouldn't I pay for this?\"\r\n\r\n\"It's on me, don't worry. Although the next time you come back for a job, come give me a visit, we could do this again.\"\r\n\r\n\"I'd like that.\" Erwin smiled.";
        Page19.SetActive(false);
        Page20.SetActive(true);
    }

    public void Ending_4()
    {
        script = "Erwin goes home after he made a new friend. He looks forward to the next time he visits Eru. The End.";
        Page20.SetActive(false);
        Page15.SetActive(false);
        Ending4.SetActive(true);
    }

    public void Ending_2()
    {
        script = "Erwin died. The End.";

        Page17.SetActive(false);
        Ending2.SetActive(true);
    }

    public void Ending_3()
    { 
        script = "The stranger died. The End.";

        Page16.SetActive(false);
        Ending3.SetActive(true);
    }

    public void Ending_1()
    {
        script = "Erwin gets throught the day uneventfully, he feels like he missed out on something. The End.";

        Page5.SetActive(false);
        Ending1.SetActive(true);
    }
}
