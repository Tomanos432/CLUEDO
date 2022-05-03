//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using StreamChat.Core.DTO.Requests;
using StreamChat.Core.DTO.Events;
using StreamChat.Core.DTO.Models;

namespace StreamChat.Core.DTO.Responses
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    internal partial class GetOGResponseDTO
    {
        [Newtonsoft.Json.JsonProperty("actions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ActionDTO> Actions { get; set; }

        [Newtonsoft.Json.JsonProperty("asset_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("author_icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorIcon { get; set; }

        [Newtonsoft.Json.JsonProperty("author_link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorLink { get; set; }

        [Newtonsoft.Json.JsonProperty("author_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        [Newtonsoft.Json.JsonProperty("color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// Duration of the request in human-readable format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Duration { get; set; }

        [Newtonsoft.Json.JsonProperty("fallback", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fallback { get; set; }

        [Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FieldDTO> Fields { get; set; }

        [Newtonsoft.Json.JsonProperty("footer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Footer { get; set; }

        [Newtonsoft.Json.JsonProperty("footer_icon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FooterIcon { get; set; }

        [Newtonsoft.Json.JsonProperty("giphy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ImagesDTO Giphy { get; set; }

        [Newtonsoft.Json.JsonProperty("image_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("og_scrape_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OgScrapeUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("pretext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pretext { get; set; }

        [Newtonsoft.Json.JsonProperty("text", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Text { get; set; }

        [Newtonsoft.Json.JsonProperty("thumb_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThumbUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Newtonsoft.Json.JsonProperty("title_link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TitleLink { get; set; }

        /// <summary>
        /// Attachment type (e.g. image, video, url)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

