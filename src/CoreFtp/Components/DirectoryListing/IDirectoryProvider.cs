﻿namespace CoreFtp.Components.DirectoryListing
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using CoreFtp.Enum;
    using Infrastructure;

    internal interface IDirectoryProvider
    {
        /// <summary>
        /// Lists all nodes in the current working directory
        /// </summary>
        /// <returns></returns>
        Task<ReadOnlyCollection<FtpNodeInformation>> ListAllAsync();

        /// <summary>
        /// Lists all files in the current working directory
        /// </summary>
        /// <returns></returns>
        Task<ReadOnlyCollection<FtpNodeInformation>> ListFilesAsync(Enum.DirSort? sortBy = null);

        IAsyncEnumerable<FtpNodeInformation> ListFilesAsyncEnum(DirSort? sortBy = null);

        /// <summary>
        /// Lists directories beneath the current working directory
        /// </summary>
        /// <returns></returns>
        Task<ReadOnlyCollection<FtpNodeInformation>> ListDirectoriesAsync();
    }
}
