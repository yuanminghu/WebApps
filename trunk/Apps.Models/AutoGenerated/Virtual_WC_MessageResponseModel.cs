//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.WC
{
	public class Virtual_WC_MessageResponseModel
	{
			public virtual string Id { get; set; }
			public virtual string OfficalAccountId { get; set; }
			public virtual Nullable<int> MessageRule { get; set; }
			public virtual Nullable<int> Category { get; set; }
			public virtual string MatchKey { get; set; }
			public virtual string TextContent { get; set; }
			public virtual string ImgTextContext { get; set; }
			public virtual string ImgTextUrl { get; set; }
			public virtual string ImgTextLink { get; set; }
			public virtual string MeidaUrl { get; set; }
			public virtual string MeidaLink { get; set; }
			public virtual bool Enable { get; set; }
			public virtual bool IsDefault { get; set; }
			public virtual string Remark { get; set; }
			public virtual int Sort { get; set; }
			public virtual System.DateTime CreateTime { get; set; }
			public virtual string CreateBy { get; set; }
			public virtual System.DateTime ModifyTime { get; set; }
			public virtual string ModifyBy { get; set; }
		}
}
