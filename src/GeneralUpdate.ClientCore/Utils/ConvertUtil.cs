﻿using GeneralUpdate.ClientCore.DTOs;
using GeneralUpdate.ClientCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneralUpdate.ClientCore.Utils
{
    public class ConvertUtil
    {
        public static UpdateVersion ToUpdateVersion(UpdateVersionDTO versionDTO)
        {
            return new UpdateVersion(versionDTO.MD5, versionDTO.PubTime, versionDTO.Version, versionDTO.Url, versionDTO.Name);
        }

        public static List<UpdateVersion> ToUpdateVersions(List<UpdateVersionDTO> versionDTOs)
        {
            var versions = new List<UpdateVersion>();
            versionDTOs.ForEach(v => versions.Add(ToUpdateVersion(v)));
            versions = versions.OrderBy(v=>v.PubTime).ToList();
            return versions;
        }
    }
}
