﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NAction {

    public class Projectile : Action
    {
        [SerializeField]
        NEntity.Projectile PREFAB_PROJECTILE;
        
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public override void use(NMotor.Motor motor)
        {
            base.use(motor);
            NEntity.Projectile proj =  GameObject.Instantiate(PREFAB_PROJECTILE).GetComponent<NEntity.Projectile>();
            proj.transform.position = motor.getAvatar().m_weapon.transform.position;
            proj.transform.rotation = motor.getAvatar().m_weapon.transform.rotation;
            Physics.IgnoreCollision(proj.m_colliderProjectile.GetComponent<Collider>(), motor.getCollisionAvatar().m_headCollider);
            Physics.IgnoreCollision(proj.m_colliderProjectile.GetComponent<Collider>(), motor.getCollisionAvatar().m_bodyColldier);
        }
    }

}