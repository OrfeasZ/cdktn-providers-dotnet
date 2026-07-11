using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermOracleExadataInfrastructure
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermOracleExadataInfrastructure.DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference), fullyQualifiedName: "azurerm.dataAzurermOracleExadataInfrastructure.DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermOracleExadataInfrastructureMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customActionTimeoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CustomActionTimeoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DaysOfWeek
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hoursOfDay", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] HoursOfDay
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "leadTimeInWeeks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LeadTimeInWeeks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "monthlyPatchingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MonthlyPatchingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "months", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Months
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Preference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] WeeksOfMonth
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermOracleExadataInfrastructure.DataAzurermOracleExadataInfrastructureMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.DataAzurermOracleExadataInfrastructure.IDataAzurermOracleExadataInfrastructureMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermOracleExadataInfrastructure.IDataAzurermOracleExadataInfrastructureMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
