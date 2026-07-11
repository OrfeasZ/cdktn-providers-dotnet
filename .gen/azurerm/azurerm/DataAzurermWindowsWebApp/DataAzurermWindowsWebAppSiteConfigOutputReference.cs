using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermWindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigOutputReference), fullyQualifiedName: "azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermWindowsWebAppSiteConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermWindowsWebAppSiteConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermWindowsWebAppSiteConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermWindowsWebAppSiteConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alwaysOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "apiDefinitionUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiDefinitionUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "apiManagementApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementApiId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "appCommandLine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppCommandLine
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationStack", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStackList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStackList ApplicationStack
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigApplicationStackList>()!;
        }

        [JsiiProperty(name: "autoHealSetting", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigAutoHealSettingList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigAutoHealSettingList AutoHealSetting
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigAutoHealSettingList>()!;
        }

        [JsiiProperty(name: "containerRegistryManagedIdentityClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerRegistryManagedIdentityClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerRegistryUseManagedIdentity", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ContainerRegistryUseManagedIdentity
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigCorsList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigCorsList Cors
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigCorsList>()!;
        }

        [JsiiProperty(name: "defaultDocuments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DefaultDocuments
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "detailedErrorLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DetailedErrorLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ftpsState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FtpsState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handlerMapping", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigHandlerMappingList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigHandlerMappingList HandlerMapping
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigHandlerMappingList>()!;
        }

        [JsiiProperty(name: "healthCheckEvictionTimeInMin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckEvictionTimeInMin
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "ipRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigIpRestrictionList IpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigIpRestrictionList>()!;
        }

        [JsiiProperty(name: "ipRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localMysqlEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LocalMysqlEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "managedPipelineMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedPipelineMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumTlsCipherSuite", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsCipherSuite
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumTlsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remoteDebuggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RemoteDebuggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "remoteDebuggingVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteDebuggingVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmIpRestriction", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigScmIpRestrictionList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigScmIpRestrictionList ScmIpRestriction
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigScmIpRestrictionList>()!;
        }

        [JsiiProperty(name: "scmIpRestrictionDefaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmIpRestrictionDefaultAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scmMinimumTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmMinimumTlsVersion
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

        [JsiiProperty(name: "use32BitWorker", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Use32BitWorker
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "virtualApplication", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigVirtualApplicationList\"}")]
        public virtual azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigVirtualApplicationList VirtualApplication
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfigVirtualApplicationList>()!;
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

        [JsiiProperty(name: "windowsFxVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowsFxVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermWindowsWebApp.DataAzurermWindowsWebAppSiteConfig\"}", isOptional: true)]
        public virtual azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppSiteConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermWindowsWebApp.IDataAzurermWindowsWebAppSiteConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
