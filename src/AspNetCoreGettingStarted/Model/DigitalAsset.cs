﻿using System;

namespace AspNetCoreGettingStarted.Model
{
    public class DigitalAsset 
    {
        public Guid DigitalAssetId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? FileModified { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsSecure { get; set; }
        public string ContentType { get; set; }
        public string RelativePath { get { return $"api/digitalassets/serve?digitalassetid={DigitalAssetId}"; } }
        public Byte[] Bytes { get; set; } = new byte[0];
        public string Folder { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? UploadedOn { get; set; }
        public string UploadedBy { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
