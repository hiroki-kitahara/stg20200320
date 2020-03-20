﻿using UnityEngine;
using UnityEngine.Assertions;

namespace HK.STG
{
    /// <summary>
    /// タグを設定する<see cref="ActorBuilder"/>
    /// </summary>
    public sealed class SetTag : ActorBuilder
    {
        [SerializeField]
        private Tags.Enum tagType = default;

        public override void Entry(Actor actor)
        {
            actor.tag = Tags.AsName(this.tagType);
        }
    }
}
