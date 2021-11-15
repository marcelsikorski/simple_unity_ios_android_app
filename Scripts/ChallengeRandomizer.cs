using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ChallengeRandomizer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public TMP_Text m_MyQuestion;
    public TMP_Text m_MyPenalty;
    public Button Randomizer;
    public bool isClicked = false;
    int roundCounter = 0;
    public GameObject Panel;

    public void OnPointerDown(PointerEventData eventData)
    {
        isClicked = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isClicked = false;
    }

    public List<string> penalties = new List<string>()
    {
            "You and 2 chosen people drink!",
            "You need to chug your drink or have two shots!",
            "Everyone drinks!",
            "You and 1 chosen person need to drink!",
            "You need to drink along with a person on your left and on your right!",
            "You and people choosen by you need to drink 2 turns!",
            "You need to drink 2 shots but if someone wants to help you they can take one!",
            "You need to chug a beer, if there is no beer around you you need to drink 2 turns!",
            "Choose half of the group to drink alongside you!",
            "Choose the least drunk person in your opinion and take a shot along with them!",
            "Everybody drink one, you drink two!"
    };

    public List<string> questions = new List<string>()
    {
            "What’s the last lie you told?",
            "What was the most embarrassing thing you’ve ever done on a date?",
            "Have you ever accidentally hit something (or someone!) with your car?",
            "Can you name someone you’ve pretended to like but actually couldn’t stand?",
            "What’s your most bizarre nickname?",
            "What’s been your most physically painful experience?",
            "What bridges are you glad that you burned",
            "What’s the craziest thing you’ve done on public transportation?",
            "If you met a genie, what would your three wishes be?",
            "If you could write anyone on Earth in for President of the United States, who would it be and why?",
            "What’s the meanest thing you’ve ever said to someone else?",
            "What’s something you love to do with your friends that you’d never do in front of your partner?",
            "Who was your worst kiss ever?",
            "What’s one thing you’d do if you knew there no consequences?",
            "What’s the craziest thing you’ve done in front of a mirror?",
            "What’s the meanest thing you’ve ever said about someone else?",
            "Who are you most jealous of?",
            "What do your favorite pajamas look like?",
            "Have you ever faked sick to get out of a party?",
            "Who’s the oldest person you’ve dated?",
            "How many selfies do you take a day?",
            "Who in this room would you most want to kiss?",
            "Who in this room would you most want to sleep with?",
            "Who in this room would you most want to see naked?",
            "How old were you when you had sex for the first time?",
            "Do you ever watch porn?",
            "How often do you masturbate?",
            "Do you own any sex toys? (And if yes, what are they?)",
            "What's the most embarrassing thing that's ever happened to you during sex?",
            "What's the grossest thing that's ever happened to you during sex?",
            "Who's the best kisser you've ever met?",
            "Who's the best sexual partner you've ever had?",
            "Have you ever had a threesome?",
            "Have you ever gone skinny-dipping?",
            "What's the weirdest thing that turns you on?",
            "Have you ever fantasized about a coworker?",
            "Have you ever had sex in public?",
            "Have you ever been caught having sex?",
            "Have you ever walked in on people having sex?",
            "Have you ever taken nudes?",
            "Have you ever recorded yourself having sex?",
            "Have you ever been to a sex party?",
            "Have you ever tied someone up/been tied up in bed?",
            "Have you ever spanked someone/been spanked in bed?",
            "Have you ever had anal sex?",
            "Have you ever tried role playing in bed, and what were the roles?",
            "If you could only bring one sex toy to a desert island, what would it be?",
            "If you could only do one sex act for the rest of your life, what would it be?",
            "Which would you rather give up for a year: sex or alcohol?",
            "Which would you rather give up for a year: partner sex or masturbation?",
            "Have you ever cheated on a partner?",
            "Have you ever had sex in a car?",
            "Who was your first sexual partner?",
            "Which would you rather give up for a year: kissing or masturbation?",
            "Have you ever hooked up with a friend?",
            "Have you ever blindfolded someone/been blindfolded in bed?",
            "What's the highest number of orgasms you've had in a day?",
            "Have you ever had sex in the shower?",
            "Have you ever had sex in a pool or hot tub?",
            "Have you ever hooked up with someone ten (or more) years older or younger than you?",
            "Do you prefer giving or receiving oral sex?",
            "Have you ever hooked up with someone whose name you didn't know?",
            "Have you ever faked an orgasm?",
            "What's the hottest thing about your current partner?",
            "Have you ever eaten food from the floor?",
            "Have you ever eaten or been tempted to eat your dog’s treats?",
            "Have you ever farted in an elevator?",
            "Have you ever peed in a pool?",
            "Have you ever used an inappropriate word in front of your parents?",
            "How many days have you ever gone without taking a shower?",
            "If you could suddenly become invisible, what more naughty things would you like to do?",
            "What is the most stupid thing you’ve done in front of a crowd?",
            "What’s something stupid you’ve done that you’re most proud of?",
            "What is the strangest thing you have ever bought?",
            "If you were given a million dollars, what would you do with it?",
            "What makes you the happiest?",
            "Is there any movie that always makes you cry?",
            "Have you ever been attracted to the same sex?",
            "What’s your favorite body part on a guy?",
            "Have you ever been to a strip club?",
            "What’s your favorite body part on a girl?",
            "What’s been on your mind lately?",
            "Do you have a hot cousin?",
            "If you were to give a full body massage, where would you start and where would you end?",
            "Have you ever dyed your hair?",
            "What is your favorite plant and why?",
            "Do you ever smell your toes?",
            "How often do you pick your nose?",
            "What’s the grossest thing that you do when you’re alone?",
            "When you were eight years old, what did you want to be when you grew up?",
            "What’s the strangest game you used to play as a kid?",
            "What were you doing one year ago today?",
            "Have you kissed anyone in this room?",
            "Who’s the most boring person here?",
            "What would you name your children?",
            "What's something you wish you didn’t know?",
            "What’s the lamest thing you’ve Googled?",
            "When was the last time you pooped or peed your pants?",
            "Where do most of your embarrassing odors come from?",
            "Have you ever considered cheating on a partner?",
            "If you were guaranteed to never get caught, who on Earth would you murder?",
            "What’s the cheapest gift you’ve ever gotten for someone else?",
            "What app do you waste the most time on?",
            "What’s the weirdest thing you’ve done on a plane?",
            "What is the youngest age partner you’d date?",
            "Have you ever lied about your age?",
            "If you had to delete one app from your phone, which one would it be?",
            "What’s your most embarrassing late night purchase?",
            "Have you ever used a fake ID?",
            "What is your greatest fear in a relationship?",
            "Have you ever seen a dead body?",
            "What celebrity do you think is overrated?",
            "Have you ever lied to your boss?",
            "Have you ever stolen something from work?",
            "What’s the longest you’ve gone without brushing your teeth?",
            "What’s your biggest regret in life?",
            "Have you ever regifted a present?",
            "Would you break up with your partner for $1 million?",
            "Do you still have feelings for any of your exes?",
            "What’s the smallest tip you’ve ever left at a restaurant?",
            "Have you ever regretted something you did to get a crush or partner’s attention?",
            "What’s one job you could never do?",
            "Have you ever ghosted a partner?",
            "What’s the most scandalous photo in your cloud?",
            "If you switched genders for a day, what would you do?",
            "How many photo editing apps do you have on your phone?",
            "Who in this room would you list as your emergency contact?",
            "What’s something you would die if your mom found out about?",
            "What’s the scariest thing that’s ever happened to you?",
            "What’s the weirdest dream you’ve ever had?",
            "Have you ever had a one-night stand?",
            "Are you scared of getting old?",
            "What do you want on your tombstone?",
            "If you had one week to live and you had to marry someone in this room, who would it be?",
            "Who would you call to help bury a body?",
            "If someone would call you to help bury a body? Would you do it?",
            "What’s your favorite possession?",
            "Has anyone ever walked in on you in the bathroom?",
            "Who in this group would you want to swap lives with for a week?",
            "What was your biggest fear as a child?",
            "What’s your biggest fear today?",
            "What’s the most embarrassing thing your parents have caught you doing?",
            "If you could only hear one song for the rest of your life, what would it be?",
            "What’s the last YouTube video you watched?",
            "What’s the hardest drug you’ve ever tried?",
            "Who in this room would be your one phone call if you were in jail?",
            "Who do you most often text on the toilet?",
            "What’s the craziest thing you’ve ever done in a movie theater?",
            "What’s the craziest thing that has happened to you in a mall?",
            "How long was your longest relationship?",
            "Have you ever been arrested?",
            "Who’s the most surprising person to ever slide into your DMs?",
            "Where’s one place you’re dying to visit?",
            "What word do you hate the most?",
            "What’s the most embarrassing thing you’ve ever posted on social media?",
            "If you could hire someone to do one thing for you, what would it be?",
            "Would you ever consider being a nudist?",
            "What’s the best lie you’ve ever told anyone?",
            "Who’s the last person you lurked on social media?",
            "What’s your most embarrassing childhood memory?",
            "Have you ever pretended to not get a text to get out of doing something?",
            "What’s the weirdest thing you’ve ever done in a bathroom?",
            "What’s the most insane thing you’ve done to get out of a speeding ticket?",
            "Do you have any hidden talents? What are they?",
            "When’s the last time you got caught in a lie?",
            "How do you really feel about your mother-in-law?",
            "What do you think happens when you die?",
            "When’s the last time you watched an adult movie?",
            "Have you ever been in a fight?",
            "Would you marry someone rich even if you weren’t in love with them?",
            "Have you ever been caught checking someone out?",
            "What’s the worst advice you’ve ever given someone else?",
            "What’s the worst advice someone else has ever given you?",
            "Would you volunteer as tribute for anyone in this room in The Hunger Games?",
            "Is there an ex with whom you’d consider reconciling?",
            "What’s the weirdest thing you do while driving?",
            "Who’s the last person who called you?",
            "When’s the last time you wanted to hit somebody?",
            "What’s the grossest smell that you secretly enjoy?",
            "What’s the biggest prank you’ve ever played on someone?",
            "What’s one thing about your partner that you find least attractive?",
            "When was the last time you were really angry? Why?",
            "What’s your least favorite memory from college?",
            "Have you ever intentionally sabotaged a coworker?",
            "Would you ever get plastic surgery?",
            "Have you ever had a near-death experience?",
            "What’s a skill you wish you had?",
            "Have you ever compromised your morals for money? How?",
            "What was your first heartbreak?",
            "Have you ever broken someone’s heart?",
            "Have you ever thrown up in public?",
            "When’s the last time you got rejected?",
            "What’s the most common misconception about you?",
            "Have you ever seriously injured another person?",
            "When did you stop believing in Santa Claus?",
            "What’s one responsibility you wish you didn’t have?",
            "Who is the best kisser you’ve ever had?",
            "Have you ever had a paranormal experience?",
            "Have you ever gotten blackout drunk?",
            "Do you believe in aliens?",
            "What’s something you’ve done that you still feel guilty about?",
            "What is the worst date you’ve ever been on?",
            "What’s the weirdest thing you’ve ever collected?",
            "What’s the weirdest thing you’ve ever said to a stranger?",
            "Who in this room do you trust the least?",
            "What’s the most inappropriate time you’ve ever laughed?",
            "What’s your best pickup line?",
            "What’s the weirdest place you’ve ever given or gotten someone’s number?",
            "What’s the dumbest thing you’ve ever lied about?",
            "What’s your least favorite memory from high school?",
            "Have you ever said, “I love you” and not really meant it? To whom?",
            "What’s the worst present someone has ever given you?",
            "When’s the last time you shared a toothbrush with someone else?",
            "Have you ever had a crush on a boss or teacher?",
            "What’s the weirdest thought you’ve had sitting on a toilet?",
            "What song do you sing most in the shower?",
            "What’s the cruelest thing you’ve ever done or said to a romantic partner?",
            "Who’s the person you most regret hooking up with?",
            "What’s something you’re embarrassed that you’re good at?",
            "Who would you bring with you on a deserted island?",
            "What’s the worst decision one of the other players has ever made?",
            "Have you ever been fired from a job?",
            "Have you ever let someone take the blame for something you did?",
            "What’s the most ridiculous thing you have an emotional attachment to?",
            "Have you ever pooped your pants as an adult?",
            "What’s something you’ve done that you’d judge someone else for doing?",
            "What’s something weird you do in your sleep?",
            "Who’s your hero?",
            "What’s something you know you need to do but aren’t looking forward to at all?",
            "What’s the biggest secret you’ve kept from your parents?",
            "What’s the most offensive joke you’ve found funny?",
            "What are you most proud of in your life?",
            "When’s the last time you lurked an ex on social media?",
            "If you were rescuing people from a burning building and you had to leave one person behind from this room, who would it be?"
    };

    public void Start()
    {
        var random = new System.Random();
        int index = random.Next(penalties.Count);
        // Debug.Log(penalties[index]);
        m_MyPenalty.text = penalties[index];

        var randomq = new System.Random();
        int indexq = randomq.Next(questions.Count);
        m_MyQuestion.text = questions[indexq];
    }

    void Update()
    {
        if (isClicked)
        {
            var random = new System.Random();
            int index = random.Next(penalties.Count);
            // Debug.Log(penalties[index]);
            m_MyPenalty.text = penalties[index];

            var randomq = new System.Random();
            int indexq = randomq.Next(questions.Count);
            m_MyQuestion.text = questions[indexq];

            roundCounter++;
            if (roundCounter == 15 && Panel != null)
            {
                bool isActive = Panel.activeSelf;
                Panel.SetActive(!isActive);
                roundCounter = 0;
            }
        }
        isClicked = false;
    }
}