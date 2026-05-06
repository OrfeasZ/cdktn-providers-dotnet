using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFusionAppsFusionEnvironments
{
    [JsiiClass(nativeType: typeof(oci.DataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference), fullyQualifiedName: "oci.dataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "environmentMaintenanceOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentMaintenanceOverride
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monthlyPatchingOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyPatchingOverride
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyQuarterlyUpgradeBeginTimesList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyQuarterlyUpgradeBeginTimesList QuarterlyUpgradeBeginTimes
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicyQuarterlyUpgradeBeginTimesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironments.DataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicy\"}", isOptional: true)]
        public virtual oci.DataOciFusionAppsFusionEnvironments.IDataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironments.IDataOciFusionAppsFusionEnvironmentsFusionEnvironmentCollectionItemsMaintenancePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
