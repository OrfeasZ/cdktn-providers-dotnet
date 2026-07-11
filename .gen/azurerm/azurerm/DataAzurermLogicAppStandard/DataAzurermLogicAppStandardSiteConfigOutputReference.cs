using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLogicAppStandard
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigOutputReference), fullyQualifiedName: "azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermLogicAppStandardSiteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermLogicAppStandardSiteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermLogicAppStandardSiteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermLogicAppStandardSiteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alwaysOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "appScaleLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AppScaleLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autoSwapSlotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoSwapSlotName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigCorsList\"}")]
        public virtual azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigCorsList Cors
        {
            get => GetInstanceProperty<azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigCorsList>()!;
        }

        [JsiiProperty(name: "dotnetFrameworkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DotnetFrameworkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticInstanceMinimum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ElasticInstanceMinimum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpsState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "http2Enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Http2Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigIpRestrictionList IpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigIpRestrictionList>()!;
        }

        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linuxFxVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinuxFxVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preWarmedInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PreWarmedInstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "runtimeScaleMonitoringEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RuntimeScaleMonitoringEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigScmIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigScmIpRestrictionList ScmIpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfigScmIpRestrictionList>()!;
        }

        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmIpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmMinTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmMinTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmUseMainIpRestriction", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ScmUseMainIpRestriction
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "use32BitWorkerProcess", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Use32BitWorkerProcess
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "vnetRouteAllEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable VnetRouteAllEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "websocketsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable WebsocketsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermLogicAppStandard.DataAzurermLogicAppStandardSiteConfig\"}", isOptional: true)]
        public virtual azurerm.DataAzurermLogicAppStandard.IDataAzurermLogicAppStandardSiteConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermLogicAppStandard.IDataAzurermLogicAppStandardSiteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
