require "util"
require "story"
require "defines"
require "tightspot"

level =
{
  level_number = 5,
  time = 15 * 60 * 60,
  money = 10000,
  required_balance =
  {
    easy = 4000,
    normal = 9000,
    hard = 15000
  },
  center = {x = 0, y = 0},
  starting_land_prize = 10,
  price_increase = 2,
  area = {{-40, -40}, {40, 40}},
  recipes =
  {
    "iron-plate",
    "copper-plate",
    "copper-cable",
    "steel-plate",
    "electronic-circuit",
    "iron-gear-wheel",
    "rocket",
    "basic-inserter",
    "fast-inserter",
    "smart-inserter",
    "advanced-circuit",
    "science-pack-3",
    "plastic-bar",
    "battery",
    "sulfur",
    "sulfuric-acid",
    "basic-oil-processing",
    "advanced-oil-processing",
  },
  items =
  {
    "coal",
    "basic-transport-belt",
    "basic-transport-belt-to-ground",
    "fast-transport-belt",
    "fast-transport-belt-to-ground",
    "basic-splitter",
    "fast-splitter",
    "burner-inserter",
    "basic-inserter",
    "long-handed-inserter",
    "fast-inserter",
    "smart-inserter",
    "red-wire",
    "green-wire",
    "wooden-chest",
    "smart-chest",
    "stone-furnace",
    "steel-furnace",
    "electric-furnace",
    "offshore-pump",
    "pipe",
    "pipe-to-ground",
    "boiler",
    "steam-engine",
    "small-electric-pole",
    "medium-electric-pole",
    "big-electric-pole",
    "substation",
    "assembling-machine-1",
    "assembling-machine-2",
    "assembling-machine-3",
    "basic-mining-drill",
    "burner-mining-drill",
    "pumpjack",
    "oil-refinery",
    "chemical-plant",
    "storage-tank",
    "small-pump"
  },
  demand =
  {
    {
      item = "science-pack-3",
      price = 1500
    }
  }
}

level.offers = {}
for _, item in ipairs(level.items) do
  level.offers[#level.offers + 1] = tightspot_make_offer(item)
end

script.on_init(function()
  global.story = story_init(story_table)
  global.tightspot = tightspot_init(level)
  game.always_day = true
  game.player.force.disable_research()
end)

script.on_event(defines.events, function(event)
  story_update(global.story, event, "")
end)
