﻿namespace UnitedRemoteShopChallenge.Data.Model
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }

    }
}