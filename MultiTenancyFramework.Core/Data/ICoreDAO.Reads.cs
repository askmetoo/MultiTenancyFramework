﻿using MultiTenancyFramework.Entities;
using System;
using System.Collections.Generic;

namespace MultiTenancyFramework.Data
{
    public partial interface ICoreReadsDAO<T, idT> : ICoreGeneralDAO where T : IBaseEntity<idT> where idT : IEquatable<idT>
    {
        IList<idT> RetrieveIDs();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDs"></param>
        /// <param name="fields">fields you're interested in getting their field values. If null, all fields are selected</param>
        /// <returns></returns>
        IList<T> RetrieveByIDs(idT[] IDs, params string[] fields);

        /// <summary>
        /// Retrieves all.
        /// </summary>
        /// <param name="fields">fields you're interested in getting their field values. If null, all fields are selected</param>
        /// <returns></returns>
        IList<T> RetrieveAll(params string[] fields);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields">fields you're interested in getting their field values. If null, all fields are selected</param>
        /// <returns></returns>
        IList<T> RetrieveAllActive(params string[] fields);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields">fields you're interested in getting their field values. If null, all fields are selected</param>
        /// <returns></returns>
        IList<T> RetrieveAllInactive(params string[] fields);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fields">fields you're interested in getting their field values. If null, all fields are selected</param>
        /// <returns></returns>
        IList<T> RetrieveAllDeleted(params string[] fields);

        /// <summary>
        /// Retrieve the first item found inthe db. This is useful for tables expected to have just one enty
        /// </summary>
        /// <returns></returns>
        T RetrieveOne();

        /// <summary>
        /// Retrieves the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T Retrieve(idT id);
        
        /// <summary>
        /// Retrieves the specified id. NB: Use this only when you're sure the 
        /// T with the id exists; otherwise, use .Retrieve
        /// Use this in cases when you only need the id of T to persist another entity that
        /// references T.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        T Load(idT id);

    }

    public partial interface ICoreReadsDAO<T> : ICoreReadsDAO<T, long> where T : IEntity<long>
    {

    }
}
