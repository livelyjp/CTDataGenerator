﻿using System.Collections.Generic;
using CTDataGenerator.Utils;
using System;

namespace CTDataGenerator.Data
{
    public partial class User
    {
        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(DateTime dateOfBirth, int gender, string password)
        {
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = 0;
            this.CreationTimestamp = DateTime.Now;

            this.ActivityLogs = new HashSet<ActivityLog>();
            this.FoodLogs = new HashSet<FoodLog>();
            this.MetricLogs = new HashSet<MetricLog>();
            this.Targets = new HashSet<UserTarget>();
        }

        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(DateTime dateOfBirth, Gender gender, string password)
        {
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = 0;
            this.CreationTimestamp = DateTime.Now;

            this.ActivityLogs = new HashSet<ActivityLog>();
            this.FoodLogs = new HashSet<FoodLog>();
            this.MetricLogs = new HashSet<MetricLog>();
            this.Targets = new HashSet<UserTarget>();
        }

        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password)
        {
            this.UserID = userID;
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = 0;
            this.CreationTimestamp = DateTime.Now;

            this.ActivityLogs = new HashSet<ActivityLog>();
            this.FoodLogs = new HashSet<FoodLog>();
            this.MetricLogs = new HashSet<MetricLog>();
            this.Targets = new HashSet<UserTarget>();
        }

        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        /// <param name="admin">Admin Account</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password, bool admin)
        {
            this.UserID = userID;
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = Convert.ToSByte(admin);
            this.CreationTimestamp = DateTime.Now;

            this.ActivityLogs = new HashSet<ActivityLog>();
            this.FoodLogs = new HashSet<FoodLog>();
            this.MetricLogs = new HashSet<MetricLog>();
            this.Targets = new HashSet<UserTarget>();
        }

        /// <summary>
        /// Random User
        /// </summary>
        /// <param name="activityLevel">Activity Level</param>
        /// <param name="personalityType">Personality Type</param>
        public User(ActivityLevel activityLevel, int personalityType)
        {
            Random rand = new Random();
            this.DateOfBirth = UserUtil.GenerateRandomAge();
            this.Gender = Convert.ToSByte(rand.Next(0, 1));
            PasswordHasher passwordHasher = new PasswordHasher("temppass123");
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = Convert.ToSByte(0);
            this.CreationTimestamp = UserUtil.GenerateRandomJoinedDate();

            this.ActivityLevel = (int) activityLevel;
            this.PersonalityType = personalityType;

            this.ActivityLogs = new HashSet<ActivityLog>();
            this.FoodLogs = new HashSet<FoodLog>();
            this.MetricLogs = new HashSet<MetricLog>();
            this.Targets = new HashSet<UserTarget>();
        }
    }
}
