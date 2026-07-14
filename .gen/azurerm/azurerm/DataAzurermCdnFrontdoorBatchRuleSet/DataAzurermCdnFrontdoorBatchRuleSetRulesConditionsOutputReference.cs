using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorBatchRuleSet
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientPort", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsClientPortList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsClientPortList ClientPort
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsClientPortList>()!;
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsDeviceTypeList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsDeviceTypeList DeviceType
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsDeviceTypeList>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHostNameList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHostNameList HostName
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHostNameList>()!;
        }

        [JsiiProperty(name: "httpVersion", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHttpVersionList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHttpVersionList HttpVersion
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsHttpVersionList>()!;
        }

        [JsiiProperty(name: "postArgument", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsPostArgumentList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsPostArgumentList PostArgument
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsPostArgumentList>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsQueryStringList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsQueryStringList QueryString
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsQueryStringList>()!;
        }

        [JsiiProperty(name: "remoteAddress", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRemoteAddressList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRemoteAddressList RemoteAddress
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRemoteAddressList>()!;
        }

        [JsiiProperty(name: "requestBody", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestBodyList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestBodyList RequestBody
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestBodyList>()!;
        }

        [JsiiProperty(name: "requestCookies", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestCookiesList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestCookiesList RequestCookies
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestCookiesList>()!;
        }

        [JsiiProperty(name: "requestFileExtension", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFileExtensionList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFileExtensionList RequestFileExtension
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFileExtensionList>()!;
        }

        [JsiiProperty(name: "requestFilename", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFilenameList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFilenameList RequestFilename
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestFilenameList>()!;
        }

        [JsiiProperty(name: "requestHeader", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestHeaderList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestHeaderList RequestHeader
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestHeaderList>()!;
        }

        [JsiiProperty(name: "requestMethod", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestMethodList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestMethodList RequestMethod
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestMethodList>()!;
        }

        [JsiiProperty(name: "requestPath", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestPathList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestPathList RequestPath
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestPathList>()!;
        }

        [JsiiProperty(name: "requestScheme", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestSchemeList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestSchemeList RequestScheme
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestSchemeList>()!;
        }

        [JsiiProperty(name: "requestUrl", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestUrlList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestUrlList RequestUrl
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsRequestUrlList>()!;
        }

        [JsiiProperty(name: "serverPort", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsServerPortList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsServerPortList ServerPort
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsServerPortList>()!;
        }

        [JsiiProperty(name: "socketAddress", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSocketAddressList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSocketAddressList SocketAddress
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSocketAddressList>()!;
        }

        [JsiiProperty(name: "sslProtocol", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSslProtocolList\"}")]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSslProtocolList SslProtocol
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditionsSslProtocolList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetRulesConditions\"}", isOptional: true)]
        public virtual azurerm.DataAzurermCdnFrontdoorBatchRuleSet.IDataAzurermCdnFrontdoorBatchRuleSetRulesConditions? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermCdnFrontdoorBatchRuleSet.IDataAzurermCdnFrontdoorBatchRuleSetRulesConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
