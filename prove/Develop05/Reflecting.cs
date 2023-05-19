using System;
using System.Collections.Generic;

public class Reflecting
{
    protected List<string> _prompts = new List<string>
    {
        "--- Goals are the roadmap to success, providing direction and purpose in life. ---",
        "--- Setting goals gives us something to strive for and helps us push beyond our comfort zones to achieve greatness. ---",
        "--- Without goals, we wander aimlessly through life, lacking motivation and a sense of fulfillment. ---",
        "--- Goals act as a catalyst for personal growth and development, allowing us to constantly challenge ourselves and reach new heights. ---",
        "--- Having clear goals allows us to prioritize our time and resources effectively, making progress towards what truly matters to us. ---",
        "--- Goals give us a sense of purpose and drive, fueling our motivation to overcome obstacles and achieve our dreams. ---",
        "--- Setting goals helps us measure our progress and celebrate our accomplishments along the way, boosting our self-confidence and satisfaction. ---",
        "--- Having well-defined goals enables us to make better decisions and stay focused on what truly matters, preventing distractions and wasted efforts. ---",
        "--- Goals provide a sense of direction, helping us channel our energy and resources towards meaningful endeavors. ---",
        "--- Setting challenging goals inspires us to tap into our full potential, unlocking hidden talents and abilities we never knew we had. ---",
        "--- Goals foster perseverance and resilience, teaching us valuable lessons about dedication and the importance of staying committed to our aspirations. ---",
        "--- By setting goals, we create a roadmap for growth and self-improvement, constantly striving to become the best version of ourselves. ---",
        "--- Goals help us prioritize our actions, ensuring that we allocate our time and energy towards activities that align with our long-term vision. ---",
        "--- Without goals, we risk becoming stagnant and complacent, missing out on opportunities for personal and professional advancement. ---",
        "--- Setting goals empowers us to take control of our lives, shaping our future according to our desires and aspirations. ---"
    };

    private Random _random = new Random();


    public string DisplayRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts = new List<string>
    {
        "--- Goals are the roadmap to success, providing direction and purpose in life. ---",
        "--- Setting goals gives us something to strive for and helps us push beyond our comfort zones to achieve greatness. ---",
        "--- Without goals, we wander aimlessly through life, lacking motivation and a sense of fulfillment. ---",
        "--- Goals act as a catalyst for personal growth and development, allowing us to constantly challenge ourselves and reach new heights. ---",
        "--- Having clear goals allows us to prioritize our time and resources effectively, making progress towards what truly matters to us. ---",
        "--- Goals give us a sense of purpose and drive, fueling our motivation to overcome obstacles and achieve our dreams. ---",
        "--- Setting goals helps us measure our progress and celebrate our accomplishments along the way, boosting our self-confidence and satisfaction. ---",
        "--- Having well-defined goals enables us to make better decisions and stay focused on what truly matters, preventing distractions and wasted efforts. ---",
        "--- Goals provide a sense of direction, helping us channel our energy and resources towards meaningful endeavors. ---",
        "--- Setting challenging goals inspires us to tap into our full potential, unlocking hidden talents and abilities we never knew we had. ---",
        "--- Goals foster perseverance and resilience, teaching us valuable lessons about dedication and the importance of staying committed to our aspirations. ---",
        "--- By setting goals, we create a roadmap for growth and self-improvement, constantly striving to become the best version of ourselves. ---",
        "--- Goals help us prioritize our actions, ensuring that we allocate our time and energy towards activities that align with our long-term vision. ---",
        "--- Without goals, we risk becoming stagnant and complacent, missing out on opportunities for personal and professional advancement. ---",
        "--- Setting goals empowers us to take control of our lives, shaping our future according to our desires and aspirations. ---"
    };
        }
        int index = _random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        Console.WriteLine($"{prompt}");
        return prompt;
    }
}