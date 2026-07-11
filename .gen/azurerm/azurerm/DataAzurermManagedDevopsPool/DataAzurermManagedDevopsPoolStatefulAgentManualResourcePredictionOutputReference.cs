using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference), fullyQualifiedName: "azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allWeekSchedule", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllWeekSchedule
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fridaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList FridaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionFridayScheduleList>()!;
        }

        [JsiiProperty(name: "mondaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList MondaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionMondayScheduleList>()!;
        }

        [JsiiProperty(name: "saturdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList SaturdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSaturdayScheduleList>()!;
        }

        [JsiiProperty(name: "sundaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList SundaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionSundayScheduleList>()!;
        }

        [JsiiProperty(name: "thursdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList ThursdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionThursdayScheduleList>()!;
        }

        [JsiiProperty(name: "timeZoneName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZoneName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tuesdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList TuesdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionTuesdayScheduleList>()!;
        }

        [JsiiProperty(name: "wednesdaySchedule", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList\"}")]
        public virtual azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList WednesdaySchedule
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePredictionWednesdayScheduleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedDevopsPool.DataAzurermManagedDevopsPoolStatefulAgentManualResourcePrediction\"}", isOptional: true)]
        public virtual azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolStatefulAgentManualResourcePrediction? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedDevopsPool.IDataAzurermManagedDevopsPoolStatefulAgentManualResourcePrediction?>();
            set => SetInstanceProperty(value);
        }
    }
}
