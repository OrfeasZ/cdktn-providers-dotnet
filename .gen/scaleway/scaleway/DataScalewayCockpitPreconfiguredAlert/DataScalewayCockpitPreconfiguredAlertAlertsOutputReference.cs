using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayCockpitPreconfiguredAlert
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlertsOutputReference), fullyQualifiedName: "scaleway.dataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlertsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayCockpitPreconfiguredAlertAlertsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayCockpitPreconfiguredAlertAlertsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayCockpitPreconfiguredAlertAlertsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayCockpitPreconfiguredAlertAlertsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Annotations
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Duration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preconfiguredRuleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreconfiguredRuleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayCockpitPreconfiguredAlert.DataScalewayCockpitPreconfiguredAlertAlerts\"}", isOptional: true)]
        public virtual scaleway.DataScalewayCockpitPreconfiguredAlert.IDataScalewayCockpitPreconfiguredAlertAlerts? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayCockpitPreconfiguredAlert.IDataScalewayCockpitPreconfiguredAlertAlerts?>();
            set => SetInstanceProperty(value);
        }
    }
}
