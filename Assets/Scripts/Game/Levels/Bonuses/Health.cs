﻿using UnityEngine;

public class Health : Bonus
{
    // Heal
    public uint power = 30;

    // On player enter
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (other.GetComponent(nameof(Status)) is Status player)
        {
            collectSound.Play();
            player.Heal(power);
            Destroy(gameObject);
        }
    }
}