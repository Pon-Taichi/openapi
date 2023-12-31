//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace TourOfHeroesApi.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public interface IGeneratedController
    {

        /// <summary>
        /// ヒーロー一覧の取得
        /// </summary>

        /// <returns>ヒーロー一覧</returns>

        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Hero>>> GetHeroListAsync();

        /// <summary>
        /// ヒーローの新規作成
        /// </summary>

        /// <param name="body">ヒーロー情報</param>

        /// <returns>新規ヒーロー</returns>

        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> CreateHeroAsync(CreateHeroCommand body);

        /// <summary>
        /// ヒーローの取得
        /// </summary>


        /// <returns>OK</returns>

        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> GetHeroAsync(string heroId);

        /// <summary>
        /// ヒーローの更新
        /// </summary>


        /// <returns>Updated</returns>

        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> UpdateHeroAsync(string heroId);

        /// <summary>
        /// ヒーローの削除
        /// </summary>


        /// <returns>Deleted</returns>

        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteHeroAsync(string heroId);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class GeneratedController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IGeneratedController _implementation;

        public GeneratedController(IGeneratedController implementation)
        {
            _implementation = implementation;
        }

        /// <summary>
        /// ヒーロー一覧の取得
        /// </summary>
        /// <returns>ヒーロー一覧</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("heroes")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Hero>>> GetHeroList()
        {

            return _implementation.GetHeroListAsync();
        }

        /// <summary>
        /// ヒーローの新規作成
        /// </summary>
        /// <param name="body">ヒーロー情報</param>
        /// <returns>新規ヒーロー</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("heroes")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> CreateHero([Microsoft.AspNetCore.Mvc.FromBody] CreateHeroCommand body)
        {

            return _implementation.CreateHeroAsync(body);
        }

        /// <summary>
        /// ヒーローの取得
        /// </summary>
        /// <returns>OK</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("heroes/{heroId}")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> GetHero(string heroId)
        {

            return _implementation.GetHeroAsync(heroId);
        }

        /// <summary>
        /// ヒーローの更新
        /// </summary>
        /// <returns>Updated</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("heroes/{heroId}")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Hero>> UpdateHero(string heroId)
        {

            return _implementation.UpdateHeroAsync(heroId);
        }

        /// <summary>
        /// ヒーローの削除
        /// </summary>
        /// <returns>Deleted</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("heroes/{heroId}")]
        public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteHero(string heroId)
        {

            return _implementation.DeleteHeroAsync(heroId);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Heroes : System.Collections.ObjectModel.Collection<Hero>
    {

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Hero
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Occupation { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.19.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class CreateHeroCommand
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Occupation { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603