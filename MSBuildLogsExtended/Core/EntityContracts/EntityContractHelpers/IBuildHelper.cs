using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MSBuildLogsExtended.EntityContracts
{
    /// <summary>
    /// provides common methods/actions/stubs on an entity. 
    /// </summary>
	public static partial class IBuildHelper
	{

		#region Copy<...>(...), Equals<...>(...), Clone<...>(...), ToString<...>(...), 

        /// <summary>
        /// Copies the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static void Copy<T1, T2>(T1 from, T2 to)
            where T1 : IBuild
            where T2 : IBuild
        {
			to.Id = from.Id;
			to.SolutionId = from.SolutionId;
			to.Name = from.Name;
			to.Description = from.Description;
			to.BuildStartTime = from.BuildStartTime;
        } 


		#region special copy




		#endregion special copy

        /// <summary>
        /// Equals the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns>true if with same values, otherwise false</returns>
        public static bool Equals<T1, T2>(T1 from, T2 to)
            where T1 : IBuild
            where T2 : IBuild
        {
			bool _retval = true;
			_retval = _retval && to.Id == from.Id;
			_retval = _retval && to.SolutionId == from.SolutionId;
			_retval = _retval && to.Name == from.Name;
			_retval = _retval && to.Description == from.Description;
			_retval = _retval && to.BuildStartTime == from.BuildStartTime;
			return _retval;
        }

        /// <summary>
        /// Clones the specified from.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        public static T2 Clone<T1, T2>(T1 from)
            where T1 : IBuild
            where T2 : IBuild, new()
        {
            T2 _retval = new T2();
            Copy<T1, T2>(from, _retval);
            return _retval;
        }


		static string m_Format = "Id:{0};SolutionId:{1};Name:{2};Description:{3};BuildStartTime:{4};";
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <typeparam name="T">type inheritfrom <see cref="IAspNet_SqlCacheTablesForChangeNotification"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public static string ToString<T>(T input)
            where T : IBuild
        {
            return string.Format(m_Format
				, input.Id
				, input.SolutionId
				, input.Name
				, input.Description
				, input.BuildStartTime
				);
        }

		#endregion Copy<...>(...), Equals<...>(...), Clone<...>(...), ToString<...>(...), 

		#region CopyCollection<...>(...), CloneCollection<...>(...)

        /// <summary>
        /// Copies the collection.
        /// </summary>
        /// <typeparam name="T1Collection">The type of the 1 collection.</typeparam>
        /// <typeparam name="T2Collection">The type of the 2 collection.</typeparam>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public static void CopyCollection<T1Collection, T2Collection, T1, T2>(T1Collection from, T2Collection to)
            where T1Collection : IEnumerable<T1>
            where T2Collection : IList<T2>
            where T1 : IBuild
            where T2 : IBuild, new()
        {
            foreach (T1 _Item in from)
            {
                T2 _Cloned = Clone<T1, T2>(_Item);
                to.Add(_Cloned);
            }
        }

        /// <summary>
        /// Clones the collection.
        /// </summary>
        /// <typeparam name="T1Collection">The type of the 1 collection.</typeparam>
        /// <typeparam name="T2Collection">The type of the 2 collection.</typeparam>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="from">From.</param>
        /// <returns>a new instance of target collection type T2Collection</returns>
        public static T2Collection CloneCollection<T1Collection, T2Collection, T1, T2>(T1Collection from)
            where T1Collection : IEnumerable<T1>
            where T2Collection : IList<T2>, new()
            where T1 : IBuild
            where T2 : IBuild, new()
        {
            T2Collection _retval = new T2Collection();
            CopyCollection<T1Collection, T2Collection, T1, T2>(from, _retval);
            return _retval;
        } 

		#endregion CopyCollection<...>(...), CloneCollection<...>(...)

        #region GetDefaultValue<T>()

        /// <summary>
        /// Gets the default value.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IBuild"/></typeparam>
        /// <returns>a new instance with default value</returns>
        public static T GetDefaultValue<T>()
            where T : IBuild, new()
        {
            T _retval = new T();




            _retval.SolutionId = 1;


            return _retval;
        }

        #endregion GetDefaultValue<T>()

        #region NameValuePair related method



        /// <summary>
        /// Builds the name of name value pair.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IBuild"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>name of Name value pair</returns>
        public static string BuildNameOfNameValuePair<T>(T input)
            where T : IBuild, new()
        {
            return string.Format("{0}", input.Name);
        }


        /// <summary>
        /// Builds the name value pair.
        /// </summary>
        /// <typeparam name="T">type name inherit from <see cref="IBuild"/></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>a new instance of <see cref="Framework.NameValuePair"/></returns>
        public static Framework.NameValuePair BuildNameValuePair<T>(T input)
            where T : IBuild, IBuildIdentifier, new()
        {
            Framework.NameValuePair _retval = new Framework.NameValuePair(input.Id, BuildNameOfNameValuePair<T>(input));
            return _retval;
        }



        #endregion NameValuePair related method

		#region Binary In File System,  BuildPhysicalFileFullPathOfProperty...<T>(T input)


		#endregion Binary In File System,  BuildPhysicalFileFullPathOfProperty...<T>(T input)

	}
}

