var twoSum = function(nums, target) {
    const map = {}; //keep array with index by hashmap

  for (let i = 0; i < nums.length; i++) {
    const complement = target - nums[i];            //the remain value to reach target

    if (map.hasOwnProperty(complement)) {           //if remain value is saved before
      return [map[complement], i];  
    }

    map[nums[i]] = i;                               //if remain value is not saved, save
  }
};