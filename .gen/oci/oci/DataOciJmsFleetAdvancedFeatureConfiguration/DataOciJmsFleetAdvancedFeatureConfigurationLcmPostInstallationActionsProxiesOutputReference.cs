using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetAdvancedFeatureConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference), fullyQualifiedName: "oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ftpProxyHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpProxyHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ftpProxyPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FtpProxyPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpProxyHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpProxyHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpProxyPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpProxyPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpsProxyHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpsProxyHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "httpsProxyPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpsProxyPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "socksProxyHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SocksProxyHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "socksProxyPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SocksProxyPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "useSystemProxies", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UseSystemProxies
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetAdvancedFeatureConfiguration.DataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies\"}", isOptional: true)]
        public virtual oci.DataOciJmsFleetAdvancedFeatureConfiguration.IDataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetAdvancedFeatureConfiguration.IDataOciJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsProxies?>();
            set => SetInstanceProperty(value);
        }
    }
}
