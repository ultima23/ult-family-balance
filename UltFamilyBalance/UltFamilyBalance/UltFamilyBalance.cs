﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ult.Commons;
using Ult.FamilyBalance.Model;
using System.Data.SqlClient;
using System.Data.EntityClient;


namespace Ult.FamilyBalance
{
    /// <summary>
    /// 
    /// </summary>
    public class UltFamilyBalance
    {


        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        /// <summary>
        /// Numbers of years to show
        /// </summary>
        public const int FiltersYearsNumber = 6;

        /// <summary>
        /// Numbers of years in the past to show
        /// </summary>
        public const int FiltersPastYearsNumber = 4;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        /// <summary>
        /// 
        /// </summary>
        private static UltFamilyBalance _instance;

        // Initialization
        private bool _init;
        //
        private User _user;
        //
        private UltFamilyBalanceContext _context;
        // 
        private Logger _logger;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        private UltFamilyBalance()
        {
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UltFamilyBalance GetUltFamilyBalance()
        {
            if (_instance == null)
            {
                _instance = new UltFamilyBalance();
            }
            return _instance;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsInit
        {
            get { return _init; }
        }

        /// <summary>
        /// True if the theres an user logged 
        /// </summary>
        public bool IsUserLogged
        {
            get { return (_user != null); }
        }

        /// <summary>
        /// 
        /// </summary>
        public User User
        {
            get { return _user; }
        }

        /// <summary>
        /// 
        /// </summary>
        public UltFamilyBalanceContext Context
        {
            get { return _context; }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckInit()
        {
            if (_init) throw new Exception("Operation could no be executed, UltFamilyBalance is already initialized");
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckNotInit()
        {
            if (!_init) throw new Exception("Operation could no be executed, UltFamilyBalance is not yet initialized");
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckUserLoggedOut()
        {
            if (!IsUserLogged) throw new Exception("Operation could no be executed, none user logged in");
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckUserLoggedIn()
        {
            if (IsUserLogged) throw new Exception("Operation could no be executed, another user is already logged in");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            // Checks if object is not initalized
            CheckNotInit();
            // Checks if an user is already logged in
            // CheckUserLoggedIn();
            // Execution
            try
            {
                // Current user
                User usr = _user;
                // If logged do logout
                if (IsUserLogged)
                {
                    Logout();
                }
                // Search the user
                var query = (from u in _context.Users where u.Username == username && u.Password == password select u);
                // 
                if (query.Count() > 0)
                {
                    // Login search
                    usr = query.Single();
                }
                else
                {
                    // Login forcing if in debug
                    #if DEBUG
                    if (usr == null)
                    {
                        usr = _context.Users.First<User>();
                    }
                    #endif
                }
                // user save
                _user = usr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (_user != null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public void Logout()
        {
            // Checks if object is not initalized
            CheckNotInit();
            // Checks if none user is logged in
            CheckUserLoggedOut();
            // Execution
            try
            {
                // user save
                _user = null;
            }
            catch (Exception ex)
            {
                // Trace errore per debug
                #if DEBUG
                Tracer.Debug(ex);
                #endif
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionstring"></param>
        /// <param name="user_username"></param>
        /// <param name="user_password"></param>
        public void Init(string connectionstring)
        {
            // Checks initialization, if something goes wrong, throws an exception
            CheckInit();
            // Entity Framework Context
            try
            {
                // Logger
                _logger = Logger.GetDefaultLogger();
                //
                _context = new UltFamilyBalanceContext();
                // Init finished
                _init = true;
            }
            catch (Exception ex)
            {
                // Log errore
                _logger.Fatal("UltFamilyBalance init failed, unexpected error", ex);
                // Trace errore per debug
                #if DEBUG
                Tracer.Debug(ex); 
                #endif
                // Rethrow
                throw;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetSqlConnection()
        {
            return ((EntityConnection)_context.Connection).StoreConnection as SqlConnection;

        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }

    /// <summary>
    /// 
    /// </summary>
    public enum UltFamilyBalanceStatus
    {
        Idle,
        Init,
        Ready,
        Executing
    }

}
