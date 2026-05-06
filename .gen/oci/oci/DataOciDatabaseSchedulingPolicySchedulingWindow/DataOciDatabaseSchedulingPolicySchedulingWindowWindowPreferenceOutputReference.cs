using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseSchedulingPolicySchedulingWindow
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference), fullyQualifiedName: "oci.dataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"fqn\":\"oci.dataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList\"}")]
        public virtual oci.DataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList DaysOfWeek
        {
            get => GetInstanceProperty<oci.DataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceDaysOfWeekList>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Duration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isEnforcedDuration", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnforcedDuration
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "months", typeJson: "{\"fqn\":\"oci.dataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList\"}")]
        public virtual oci.DataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList Months
        {
            get => GetInstanceProperty<oci.DataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreferenceMonthsList>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] WeeksOfMonth
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseSchedulingPolicySchedulingWindow.DataOciDatabaseSchedulingPolicySchedulingWindowWindowPreference\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseSchedulingPolicySchedulingWindow.IDataOciDatabaseSchedulingPolicySchedulingWindowWindowPreference? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseSchedulingPolicySchedulingWindow.IDataOciDatabaseSchedulingPolicySchedulingWindowWindowPreference?>();
            set => SetInstanceProperty(value);
        }
    }
}
