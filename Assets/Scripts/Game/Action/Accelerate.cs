﻿using System.Collections;
using System.Collections.Generic;
using NMotor;
using UnityEngine;
using UnityEngine.Networking;

namespace NAction {

    public class Accelerate : Action
    {
        [SerializeField]
        float m_speedBonus;
        bool m_isActive = false;
        /*

        public override void useProcess(NEntity.Entity entity, Motor motor)
        {
            base.use(entity, motor);
            if (m_isActive) return;
            m_isActive = true;
            motor.m_scalarsSpeed.Add(getBonusSpeed);
        }
        public override void endProcess(NEntity.Entity entity, Motor motor)
        {
            base.end(entity, motor);
            if (!m_isActive) return;
            motor.m_scalarsSpeed.Remove(getBonusSpeed);
            m_isActive = false;
        }
        float getBonusSpeed(Motor motor)
        {
            return m_speedBonus;
        }

        public override void kFixedUpdate(NEntity.Entity entity, Motor motor, float timeElapsed)
        {
            base.kFixedUpdate(entity, motor, timeElapsed);
            if (m_isActive)
            {
            }
        }
         * */
    }

}
