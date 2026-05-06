using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementFleetComplianceReport
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementFleetComplianceReportResourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Compartment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "complianceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComplianceState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "products", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResourcesProductsList\"}")]
        public virtual oci.DataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResourcesProductsList Products
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResourcesProductsList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementFleetComplianceReport.DataOciFleetAppsManagementFleetComplianceReportResources\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementFleetComplianceReport.IDataOciFleetAppsManagementFleetComplianceReportResources? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementFleetComplianceReport.IDataOciFleetAppsManagementFleetComplianceReportResources?>();
            set => SetInstanceProperty(value);
        }
    }
}
