using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        return true;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || prisonerIsAwake || archerIsAwake)
        {
            return true;
        }
        return false;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if ((archerIsAwake && !prisonerIsAwake) || (archerIsAwake && prisonerIsAwake) || (!archerIsAwake && !prisonerIsAwake))
        { return false; }
        return true;
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent)
        {
            if ((knightIsAwake && archerIsAwake && prisonerIsAwake) || (!knightIsAwake && archerIsAwake && !prisonerIsAwake) || (!knightIsAwake && archerIsAwake && prisonerIsAwake) || (!knightIsAwake && archerIsAwake && prisonerIsAwake) ||
                (knightIsAwake && archerIsAwake && !prisonerIsAwake))
            {
                return false;
            }

        }
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
