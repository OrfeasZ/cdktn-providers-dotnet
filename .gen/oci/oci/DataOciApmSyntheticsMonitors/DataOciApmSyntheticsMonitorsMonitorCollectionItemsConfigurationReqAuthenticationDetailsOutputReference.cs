using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsMonitors
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authHeaders", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsAuthHeadersList\"}")]
        public virtual oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsAuthHeadersList AuthHeaders
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetailsAuthHeadersList>()!;
        }

        [JsiiProperty(name: "authRequestMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthRequestMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authRequestPostBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthRequestPostBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUserPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oauthScheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OauthScheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsMonitors.DataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetails\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsMonitors.IDataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsMonitors.IDataOciApmSyntheticsMonitorsMonitorCollectionItemsConfigurationReqAuthenticationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
