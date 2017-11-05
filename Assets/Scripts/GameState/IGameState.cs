﻿using UnityEngine;

namespace GameState
{
    public interface IGameState
    {
        Vector3 Move { get; }
        bool Shoot { get; }
        void Update();

    }
}