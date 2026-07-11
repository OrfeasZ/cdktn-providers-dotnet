using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxDeployment
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference), fullyQualifiedName: "azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNginxDeploymentWebApplicationFirewallStatusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attackSignaturesPackage", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusAttackSignaturesPackageList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusAttackSignaturesPackageList AttackSignaturesPackage
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusAttackSignaturesPackageList>()!;
        }

        [JsiiProperty(name: "botSignaturesPackage", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusBotSignaturesPackageList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusBotSignaturesPackageList BotSignaturesPackage
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusBotSignaturesPackageList>()!;
        }

        [JsiiProperty(name: "componentVersions", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusComponentVersionsList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusComponentVersionsList ComponentVersions
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusComponentVersionsList>()!;
        }

        [JsiiProperty(name: "threatCampaignsPackage", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusThreatCampaignsPackageList\"}")]
        public virtual azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusThreatCampaignsPackageList ThreatCampaignsPackage
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatusThreatCampaignsPackageList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentWebApplicationFirewallStatus\"}", isOptional: true)]
        public virtual azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentWebApplicationFirewallStatus? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentWebApplicationFirewallStatus?>();
            set => SetInstanceProperty(value);
        }
    }
}
